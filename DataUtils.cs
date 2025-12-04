using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace BangGiaXe
{
    internal class DataUtils
    {
        string filePath = "BangGiaXe.xml";
        XmlDocument doc = new XmlDocument();
        XmlElement root;

        public DataUtils()
        {
            if (!File.Exists(filePath))
            {
                root = doc.CreateElement("banggiaxe");
                doc.AppendChild(root);
                doc.Save(filePath);
            }
            doc.Load(filePath);
            root = doc.DocumentElement;
        }

        public List<Card> Show()
        {
            List<Card> cards = new List<Card>();
            XmlNodeList hangXeList = root.SelectNodes("hangxe");
            foreach(XmlNode hx in hangXeList)
            {
                XmlNodeList dongxeList = hx.SelectNodes("dongxe");
                foreach(XmlNode dx in dongxeList)
                {
                    Card card = new Card
                    {
                        HangXe = hx.SelectSingleNode("@ten").InnerText,
                        DongXe = dx.SelectSingleNode("@ten").InnerText,
                        PhienBan = dx.SelectSingleNode("phienban").InnerText,
                        DongCo = dx.SelectSingleNode("dongco").InnerText,
                        Gia = double.Parse(dx.SelectSingleNode("gia")?.InnerText)
                    };
                    cards.Add(card);
                }
            }
            return cards;
        }

        public bool checkAdd(string hangxe, string dongxe)
        {
            XmlNode checkNode = root.SelectSingleNode($"hangxe[@ten='{hangxe}']/dongxe[@ten='{dongxe}']");
            return checkNode != null;
        }

        public void Add(Card card)
        {
            XmlElement hangxeNode = doc.CreateElement("hangxe");

            XmlAttribute tenAttr = doc.CreateAttribute("ten");
            tenAttr.Value = card.HangXe;
            hangxeNode.Attributes.Append(tenAttr);

            root.AppendChild(hangxeNode);

            XmlElement dongXeNode = doc.CreateElement("dongxe");
            XmlAttribute tenDongXeAttr = doc.CreateAttribute("ten");
            XmlElement phienBanNode = doc.CreateElement("phienban");
            XmlElement dongCoNode = doc.CreateElement("dongco");
            XmlElement giaNode = doc.CreateElement("gia");

            tenDongXeAttr.Value = card.DongXe;
            phienBanNode.InnerText = card.PhienBan;
            dongCoNode.InnerText = card.DongCo;
            giaNode.InnerText = card.Gia.ToString();

            dongXeNode.Attributes.Append(tenDongXeAttr);
            dongXeNode.AppendChild(phienBanNode);
            dongXeNode.AppendChild(dongCoNode);
            dongXeNode.AppendChild(giaNode);

            hangxeNode.AppendChild(dongXeNode);

            doc.Save(filePath);
        }

        public bool Update(string oldHangXe, string oldDongXe, Card card)
        {
            // 1. Tìm node cũ
            XmlNode oldNode = root.SelectSingleNode(
                $"hangxe[@ten='{oldHangXe}']/dongxe[@ten='{oldDongXe}']");

            if (oldNode == null)
                return false;

            // 2. Kiểm tra trùng (nếu đổi tên dòng xe hoặc đổi hãng xe)
            XmlNode checkDup = root.SelectSingleNode(
                $"hangxe[@ten='{card.HangXe}']/dongxe[@ten='{card.DongXe}']");

            if (checkDup != null && checkDup != oldNode)
                return false;

            // 3. Tìm hãng mới (nếu không có thì tạo)
            XmlNode newHangNode = root.SelectSingleNode($"hangxe[@ten='{card.HangXe}']");
            if (newHangNode == null)
            {
                newHangNode = doc.CreateElement("hangxe");
                XmlAttribute attr = doc.CreateAttribute("ten");
                attr.Value = card.HangXe;
                newHangNode.Attributes.Append(attr);
                root.AppendChild(newHangNode);
            }

            // 4. Nếu đổi hãng → di chuyển node
            if (oldHangXe != card.HangXe)
            {
                oldNode.ParentNode.RemoveChild(oldNode);
                newHangNode.AppendChild(oldNode);
            }

            // 5. Cập nhật thuộc tính dongxe = card.DongXe
            oldNode.Attributes["ten"].Value = card.DongXe;

            // 6. Update nội dung con
            oldNode.SelectSingleNode("phienban").InnerText = card.PhienBan;
            oldNode.SelectSingleNode("dongco").InnerText = card.DongCo;
            oldNode.SelectSingleNode("gia").InnerText = card.Gia.ToString();

            // 7. Lưu file
            doc.Save(filePath);
            return true;
        }

        public bool Delete(string hangxe, string dongxe)
        {
            XmlNode cardNode = root.SelectSingleNode($"hangxe[@ten='{hangxe}']/dongxe[@ten='{dongxe}']");

            if (cardNode == null) return false;

            XmlNode dongxeNode = cardNode.ParentNode;

            dongxeNode.RemoveChild(cardNode);

            if(dongxeNode.SelectNodes("dongxe").Count == 0)
            {
                root.RemoveChild(dongxeNode);
            }

            doc.Save(filePath);
            return true;
        }

        public List<Card> Search(string hangxe, string dongxe)
        {
            List<Card> result = new List<Card>();

            string query = "hangxe";
            List<string> conditions = new List<string>();

            if (!string.IsNullOrEmpty(hangxe))
                conditions.Add($"@ten='{hangxe}'");

            if (conditions.Count > 0)
                query += "[" + string.Join(" and ", conditions) + "]";

            query += "/dongxe";

            if (!string.IsNullOrEmpty(dongxe))
                query += $"[@ten='{dongxe}']";

            // Chạy truy vấn
            XmlNodeList nodes = root.SelectNodes(query);

            foreach (XmlNode xeNode in nodes)
            {
                XmlNode node = xeNode.ParentNode;

                result.Add(new Card
                {
                    HangXe = node.Attributes["ten"].Value,
                    DongXe = xeNode.Attributes["ten"].Value,
                    PhienBan = xeNode.SelectSingleNode("phienban").InnerText,
                    DongCo = xeNode.SelectSingleNode("dongco").InnerText,
                    Gia = double.Parse(xeNode.SelectSingleNode("gia").InnerText),
                });
            }

            return result;
        }
    }
}

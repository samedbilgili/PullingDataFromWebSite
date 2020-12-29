using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace kurcekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            string exchangeRate = "http://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(exchangeRate);

            string usd = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            string euro = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;

            txtUsd.Text = usd;
            txtEuro.Text = euro;
        }

        public string clearPriceTag(string priceTag)
        {
            priceTag = priceTag.Replace(" ", "");
            priceTag = priceTag.Replace("TL", "");

            return priceTag;
        }

        private void btnHepsiburadaFiyatGetir_Click(object sender, EventArgs e)
        {
            try
            {

                trendyolFiyatGetir();
                hepsiburadaFiyatGetir();

                decimal trendyol = Convert.ToDecimal(clearPriceTag(textBox1.Text));
                decimal hepsiburada = Convert.ToDecimal(clearPriceTag(textBox2.Text));

                if (trendyol < hepsiburada)
                {
                    lblMesaj.Text = "Trenyol " + (hepsiburada - trendyol) + " TL daha kazançlı";
                }
                else
                {
                    lblMesaj.Text = "Hepsiburada " + (trendyol - hepsiburada) + " TL daha kazançlı";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void trendyolFiyatGetir()
        {
            var url = new Uri("https://www.trendyol.com/apple/iphone-12-128gb-mavi-cep-telefonu-apple-turkiye-garantili-sarj-aleti-ve-kulaklik-harictir-p-66403057?boutiqueId=547744&merchantId=104872"); // url oluştruduk
            var client = new WebClient(); // siteye erişim için client tanımladık

            client.Headers.Add("User-Agent: Other");
            var html = client.DownloadString(url); //sitenin html lini indirdik
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument(); //burada HtmlAgilityPack Kütüphanesini kullandık
            doc.LoadHtml(html); // indirdiğimiz sitenin html lini oluşturduğumuz dokumana dolduruyoruz
            var veri = doc.DocumentNode.SelectNodes("//*[@id='product-detail-app']/div/div[2]/div[2]/div[1]/div[1]/div[1]/div[3]/div/div/span")[0]; // siteden aldığımız xpath i buraya yazıp kaynak kısmını seçiyoruz
            if (veri != null)
            {
                textBox1.Text = veri.InnerHtml;
            }
        }

        public void hepsiburadaFiyatGetir()
        {
            var url = new Uri("https://www.hepsiburada.com/iphone-12-64-gb-p-HBV00000YDZXF"); // url oluştruduk
            var client = new WebClient(); // siteye erişim için client tanımladık
            client.Headers.Add("Accept: text/html, application/xhtml+xml, */*");
            client.Headers.Add("User-Agent: Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)");
            var html = client.DownloadString(url); //sitenin html lini indirdik
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument(); //burada HtmlAgilityPack Kütüphanesini kullandık
            doc.LoadHtml(html); // indirdiğimiz sitenin html lini oluşturduğumuz dokumana dolduruyoruz
            var veri = doc.DocumentNode.SelectNodes("//*[@id='offering-price']/span[1]")[0]; // siteden aldığımız xpath i buraya yazıp kaynak kısmını seçiyoruz
            if (veri != null)
            {
                textBox2.Text = veri.InnerHtml;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMesaj.Text = "";
        }
    }
}

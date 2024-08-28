using IronBarCode;
using System;

namespace BarkodGen
{
    class BarcodeOps
    {
        public static void BarkodOlustur(string barkodLink)
        {
            GeneratedBarcode barcode = BarcodeWriter.CreateBarcode(barkodLink, BarcodeEncoding.Code128, 400, 100);
            barcode.AddBarcodeValueTextBelowBarcode();
            barcode.SaveAsPng(barkodLink + ".png");
        }

        public static void BarkodOku(string barkodYolu)
        {
            var resultFromFile = BarcodeReader.Read(barkodYolu);
            Console.WriteLine("Barkod Linki: ");
            Console.WriteLine(" ");
            foreach (var barcodeValue in resultFromFile)
            {
                Console.WriteLine(barcodeValue);
            }
        }

    }
}
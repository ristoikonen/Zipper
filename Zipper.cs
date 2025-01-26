using System;
using System.Text;

namespace Zipper;

public static class Zipper
{
    public static byte[] Compress(string textToCompress)
    {
        var barr = Encoding.ASCII.GetBytes(textToCompress);
        return QuickLZ.compress(barr, 1);
    }

    public static string CompressToText(string textToCompress)
    {
        var barr = Encoding.ASCII.GetBytes(textToCompress);
        return Encoding.ASCII.GetString(QuickLZ.compress(barr, 1));
    }


    public static string DeCompress(string compressedText)
    {
        var barr = Encoding.ASCII.GetBytes(compressedText);
        return Encoding.ASCII.GetString(QuickLZ.decompress(barr));
    }

    public static string DeCompress(byte[] compressedText)
    {
        return Encoding.ASCII.GetString(QuickLZ.decompress(compressedText));
    }

}

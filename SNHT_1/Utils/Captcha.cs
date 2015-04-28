using System;
using System.Collections;
using System.Drawing;

namespace SNHT_1.Util
{
    public class Captcha
    {
        Hashtable captchaDict;
        public Captcha()
        {
            captchaDict = new Hashtable();
        } 
        public void InitCaptchaDict()
        {
            captchaDict.Add("------11-------111------1111-----11-11----11--11---11---11---11111111-------11--------11--------11--", "4");
            captchaDict.Add("---1111-----11--11---11----11--11----11---11--111----111-11--------11---1----11---11--11-----1111---", "9");
            captchaDict.Add("---1111-----11--11---11----11---11--11-----1111-----11--11---11----11--11----11---11--11-----1111---", "8");
            captchaDict.Add("-1111111---11--------11--------11-111----111--11---------11--------11--11----11---11--11-----1111---", "5"); 
            captchaDict.Add("---1111-----11--11---11----1---11--------11-111----111--11---11----11--11----11---11--11-----1111---", "6"); 
            captchaDict.Add("----11-------1111-----11--11---11----11--11----11--11----11--11----11---11--11-----1111-------11----", "0"); 
            captchaDict.Add("--11111----11---11---------11-------11------111---------11---------11--------11--11---11----11111---", "3"); 
            captchaDict.Add("-11111111--------11--------11-------11-------11-------11-------11-------11-------11--------11-------", "7"); 
            captchaDict.Add("----11-------111------1111--------11--------11--------11--------11--------11--------11------111111--", "1"); 
            captchaDict.Add("---1111-----11--11---11----11--------11-------11-------11-------11-------11-------11-------11111111-", "2");
        }

        public static String BinaryChar(Bitmap captchaBitmap, Int32 x_start, Int32 x_end)
        {
            Int32 white = 0;
            Int32 black = 0;
            String retValWhite = "";
            String retValBlack = "";
            if ((captchaBitmap.Height <= 5)
                || (x_start >= x_end)
                || (captchaBitmap.Width <= x_end))
            {
                return "";
            }

            for (int y = 5; y < captchaBitmap.Height - 5; y++)
            {
                for (int x = x_start; x <= x_end; x++)
                {
                    Color c = captchaBitmap.GetPixel(x, y);
                    if (c.R >= 252 && c.G >= 252 && c.B >= 252)
                    {
                        white++;
                        retValWhite += '1';
                        retValBlack += '-';
                    }
                    else if (c.R <= 3 && c.G <= 3 && c.B <= 3)
                    {
                        black++;
                        retValBlack += '1';
                        retValWhite += '-';
                    }
                    else
                    {
                        retValBlack += '-';
                        retValWhite += '-';
                    }
                }
            }

            return white > black ? retValWhite : retValBlack;
        }

        public String CaptchaToText(Bitmap captchaBitmap)
        {
            String retVal = "";
            String c1 = BinaryChar(captchaBitmap, 26, 35);
            String c2 = BinaryChar(captchaBitmap, 35, 44);
            String c3 = BinaryChar(captchaBitmap, 44, 53);
            String c4 = BinaryChar(captchaBitmap, 53, 62);
            String c5 = BinaryChar(captchaBitmap, 62, 71);

            if (captchaDict.Contains(c1)
                && captchaDict.Contains(c2)
                && captchaDict.Contains(c3)
                && captchaDict.Contains(c4)
                && captchaDict.Contains(c5))
            {
                retVal = (String)captchaDict[c1] + (String)captchaDict[c2] + (String)captchaDict[c3] + (String)captchaDict[c4] + (String)captchaDict[c5];
            }

            return retVal;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Istc.thirdCours.collections
{
    class Program
    {
        static string Translation(ref string Keys)
        {
            Keys = Keys.Replace("ev", "և");
            Keys = Keys.Replace("ch", "չ");
            Keys = Keys.Replace("@", "ը");
            Keys = Keys.Replace("&", "ծ");
            Keys = Keys.Replace("sh", "շ");
            Keys = Keys.Replace("EV", "եվ");
            Keys = Keys.Replace("CH", "Չ");
            Keys = Keys.Replace("SH", "Շ");
            Keys = Keys.Replace("xh", "ղ");
            Keys = Keys.Replace("XH", "Ղ");
            Keys = Keys.Replace("dz", "ձ");
            Keys = Keys.Replace("DZ", "Ձ");
            Keys = Keys.Replace(".", ":");



            return Keys;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Dictionary<char, string> TranslationArmenia = new Dictionary<char, string>();
            TranslationArmenia.Add('a', "ա");
            TranslationArmenia.Add('q', "ք");
            TranslationArmenia.Add('e', "ե");
            TranslationArmenia.Add('r', "ր");
            TranslationArmenia.Add('t', "տ");
            TranslationArmenia.Add('y', "ը");
            TranslationArmenia.Add('u', "ու");
            TranslationArmenia.Add('i', "ի");
            TranslationArmenia.Add('o', "օ");
            TranslationArmenia.Add('p', "պ");
            TranslationArmenia.Add('s', "ս");
            TranslationArmenia.Add('d', "դ");
            TranslationArmenia.Add('f', "ֆ");
            TranslationArmenia.Add('g', "գ");
            TranslationArmenia.Add('h', "հ");
            TranslationArmenia.Add('j', "ջ");
            TranslationArmenia.Add('k', "կ");
            TranslationArmenia.Add('l', "լ");
            TranslationArmenia.Add('z', "զ");
            TranslationArmenia.Add('x', "խ");
            TranslationArmenia.Add('c', "ց");
            TranslationArmenia.Add('v', "վ");
            TranslationArmenia.Add('b', "բ");
            TranslationArmenia.Add('n', "ն");
            TranslationArmenia.Add('m', "մ");
            TranslationArmenia.Add('և', "և ");
            TranslationArmenia.Add(' ', " ");
            TranslationArmenia.Add('A', "Ա");
            TranslationArmenia.Add('Q', "Ք");
            TranslationArmenia.Add('E', "Ե");
            TranslationArmenia.Add('R', "Ր");
            TranslationArmenia.Add('T', "Տ");
            TranslationArmenia.Add('Y', "Ը");
            TranslationArmenia.Add('U', "Ու");
            TranslationArmenia.Add('I', "Ի");
            TranslationArmenia.Add('O', "Օ");
            TranslationArmenia.Add('P', "Պ");
            TranslationArmenia.Add('S', "Ս");
            TranslationArmenia.Add('D', "Դ");
            TranslationArmenia.Add('F', "Ֆ");
            TranslationArmenia.Add('G', "Գ");
            TranslationArmenia.Add('H', "Հ");
            TranslationArmenia.Add('J', "Ջ");
            TranslationArmenia.Add('K', "Կ");
            TranslationArmenia.Add('L', "Լ");
            TranslationArmenia.Add('Z', "Զ");
            TranslationArmenia.Add('X', "Խ");
            TranslationArmenia.Add('C', "Ց");
            TranslationArmenia.Add('V', "Վ");
            TranslationArmenia.Add('B', "Բ");
            TranslationArmenia.Add('N', "Ն");
            TranslationArmenia.Add('M', "Մ");
            TranslationArmenia.Add(':', ":");
            TranslationArmenia.Add('չ', "չ");
            TranslationArmenia.Add('ը', "ը");
            TranslationArmenia.Add('շ', "շ");
            TranslationArmenia.Add('Չ', "Չ");
            TranslationArmenia.Add('Շ', "Շ");
            TranslationArmenia.Add('Ը', "Ը");
            TranslationArmenia.Add('?', "?");
            TranslationArmenia.Add('ղ', "ղ");
            TranslationArmenia.Add('Ղ', "Ղ");
            TranslationArmenia.Add('ձ', "ձ");
            TranslationArmenia.Add('Ձ', "Ձ");

            string x = "";
            string y = "";
            try
            {
                x = Console.ReadLine();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Translation(ref x);
            foreach (var item in x)
            {
                y += TranslationArmenia[item];

            }
            Console.WriteLine(y);



        }
    }
}

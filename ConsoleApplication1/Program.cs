using ConsoleApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechRecognitionEngine reco = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
            reco.SetInputToDefaultAudioDevice();
            reco.LoadGrammar(new DictationGrammar());
            reco.RecognizeAsync(RecognizeMode.Multiple);
            reco.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(reco_reconized);

            while (true)
            {
                Console.ReadKey();
            }
        }

        private static void reco_reconized(object sender, SpeechRecognizedEventArgs e)
        {
            // Console.WriteLine(e.Result.Text);
            string res = e.Result.Text;
            if (res.Contains("on"))
            {
                ApiHandler.PostTurnLights("true");
            }

            if (res.Contains("off"))
            {
                ApiHandler.PostTurnLights("false");
            }
        }
    }


}

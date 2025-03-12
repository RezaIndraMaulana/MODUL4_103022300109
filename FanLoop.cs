using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MODUL4_103022300109
{
    public enum fan { Quiet, Balanced, Peformance, Turbo };
    public enum kegiatan { modeUp, modeDown, turboShortcut };
    internal class FanLoop
    {
        private fan state;
        public FanLoop()
        {
            state = fan.Quiet;
        }
        public void ubahFan(kegiatan option) {
            switch (state) {
                case fan.Quiet:
                    if (option == kegiatan.modeUp)
                    {
                        state = fan.Balanced;
                    }
                    else if (option == kegiatan.turboShortcut)
                    {
                        state = fan.Turbo;
                    }
                    break;
                case fan.Balanced:
                    if (option == kegiatan.modeUp)
                    {
                        state = fan.Peformance;
                    }
                    else if (option == kegiatan.modeDown)
                    {
                        state = fan.Quiet;
                    }
                    break;
                case fan.Peformance:
                    if (option == kegiatan.modeUp)
                    {
                        state = fan.Turbo;
                    }
                    else if (option == kegiatan.modeDown)
                    {
                        state = fan.Quiet;
                    }
                    break;
                case fan.Turbo:
                    if (option == kegiatan.modeDown)
                    {
                        state = fan.Peformance;
                    }
                    else if (option == kegiatan.turboShortcut)
                    {
                        state = fan.Quiet;
                    }
                    break;
            }
        }
        public void getStatusFan()
        {
            Console.WriteLine("Fan Quiet brubah menjadi " + state);
        }
    }
}

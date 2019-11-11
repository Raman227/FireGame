using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGame_Raman
{
    public class fire
    {
        int z = 0;

        public void frstchance() {
            
            // compare the random no with the counter to generate the bulllet sound
          
                System.Media.SoundPlayer obj = new System.Media.SoundPlayer(FireGame_Raman.Properties.Resources.fire31);
                obj.Play();
          
        }
    }
}

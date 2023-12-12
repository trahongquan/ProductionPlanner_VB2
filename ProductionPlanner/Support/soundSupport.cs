using System.Media;

namespace ProductionPlanner.Support
{
    class soundSupport
    {
        public soundSupport()
        {

        }

        public void sayYes()
        {
            try
            {
                SoundPlayer Sound = new SoundPlayer(@"taunt001.wav");
                Sound.Play();
            }
            catch
            {

            }
        }

        public void sayNo()
        {
            try
            {
                SoundPlayer Sound = new SoundPlayer(@"taunt002.wav");
                Sound.Play();
            }
            catch
            {

            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
//Real-world example: Modeling a multimedia device that can play both music and videos using interfaces.

    internal class MultipleInheritance
    {
    }

    public interface IMusicPlayer
    {
        void PlayMusic();
    }

    public interface IVideoPlayer
    {
        void PlayVideo();
    }

    public class MultimediaDevice : IMusicPlayer, IVideoPlayer
    {
        public void PlayMusic()
        {
            Console.WriteLine("Playing music.");
        }

        public void PlayVideo()
        {
            Console.WriteLine("Playing video.");
        }
    }


}

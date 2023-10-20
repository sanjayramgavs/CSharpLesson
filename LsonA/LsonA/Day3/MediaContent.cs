using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LsonA.Day3
{
    public class MediaContent
    {
        public virtual void StartPlayingContent(){
            System.Console.WriteLine("Start");
        }
         public virtual void StopPlayingContent(){
            System.Console.WriteLine("Stop");
        }
         public void PausePlayingContent(){
            System.Console.WriteLine("Pause");
        }
         public void ContinuePlayingContent(){
            System.Console.WriteLine("Continue");
        }
        
    }
    /// <summary>
    /// by default it is not possible to override the method from child to parent
    /// parent to permit the child to over
    /// virtual method can be overridden by child
    /// method from parent class must be virtual to override
    /// bydefault virtual in java
    /// 
    /// by using Sealed keyword the class cannt be overriden , but can be inherited
    /// sealed class cant be inherited
    /// </summary>
    internal class AudioContent : MediaContent{
        public override void StartPlayingContent(){
           System.Console.WriteLine("Start playing audio");
        }
        public override sealed void StopPlayingContent(){
            System.Console.WriteLine("Stop playing audio");
        }
    // it gives an error without virtual method

    }
    internal class VideoContent : MediaContent{

    }
    internal class MediaTester{
        public static void TestOne(){
                      
        }
 
    }
}
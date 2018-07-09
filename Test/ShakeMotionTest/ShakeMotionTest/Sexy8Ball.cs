using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ShakeMotionTest
{
    class Sexy8Ball
    {
        private System.Timers.Timer _timer;
        private int _countSeconds;

        public Sexy8Ball()

        { }


        public  List<string> Actions = new List<string>
        {"Lick", "Suck", "Blow", "Kiss", "Stare", "Wild", "Touch", "Bite", "Massage", "Fondle", "Stroke"};

        public  List<string> BodyParts = new List<string>
        {"Elbow","Toes","Face", "Feet", "Hand", "Upper Body","Arms", "Legs",
            "Lower Body", "Lips", "Ear",  "Eyes" ,"Back","Shoulders","Hair",
            "Thigh", "Groin", "Ass", "Neck", "Nipple", "Belly Button", "Knee", "Wild", "Whole Body"};

        public List<string> FilthyBodyParts = new List<string>
        {"Elbow","Toes","Face", "Feet", "Hand", "Upper Body","Arms", "Legs",
            "Lower Body", "Lips", "Ear",  "Eyes" ,"Back","Shoulders","Hair",
            "Thigh", "Groin", "Ass", "Neck", "Nipple", "Belly Button", "Knee", "Wild", "Whole Body",
        "Dick", "Balls", "Pussy", "Clit", "Tits", "Pussy Lips"};

        public string GetBodyPart()
        {
            Random random = new Random();
            int RandomNumber = random.Next(0, BodyParts.Count);
            return BodyParts[RandomNumber];
        }
        public string GetFilthyBodyPart()
        {
            Random random = new Random();
            int RandomNumber = random.Next(0, FilthyBodyParts.Count);
            return FilthyBodyParts[RandomNumber];
        }
        public  string GetAction()
        {      
            Random random = new Random();
            int RandomNumber = random.Next(0, Actions.Count);
            return Actions[RandomNumber];
        }

        public void CountDown()
        {
            
        }
    }
}
using System;

namespace Attributes
{
    public class DebugInfo : Attribute
    {
        private readonly int _bugNumber;
        private readonly string _developer;
        private readonly string _lastReview;

        public DebugInfo(int bg, string dev, string d)
        {
            _bugNumber = bg;
            _developer = dev;
            _lastReview = d;
        }

        public int BugNumber
        {
            get { return _bugNumber; }
        }

        public string Developer
        {
            get { return _developer; }
        }

        public string LastReview
        {
            get { return _lastReview; }
        }

        public string Message { set; get; }
    }
}
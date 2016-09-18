using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinformsImeControlWithUserControlBasics.L008DisplayYourOwnCandidateWindow {
    public class CandidateList {
        public int  DwSize;       
        public int  DwStyle;      
        public int  DwCount;      
        public int  DwSelection;  
        public int  DwPageStart;  
        public int  DwPageSize;
        public List<string> CandidateStrings = new List<string>();
    }
}

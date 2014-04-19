using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;

namespace QuickTNC
{
    class ScriptParser
    {
        public ScriptParser()
        {
        }

        public String parse(String line)
        {
            return Regex.Replace(line, "\\$([^\\s\\$]+)", delegate(Match match)
            {
                return expand(match.Groups[1].Value);
            });
        }

        private String expand(String token)
        {
            Console.Write("Expanding " + token.ToUpper() + "\n");
            PropertyInfo prop = GetType().GetProperty(token.ToUpper(), BindingFlags.Instance | BindingFlags.NonPublic);
            if (prop != null)
            {
                return (String)prop.GetValue(this, null);
            }
            return "$" + token;
        }

        private String YYYY
        {
            get
            {
                return DateTime.Today.ToString("yyyy");
            }
        }

        private String YY
        {
            get
            {
                return DateTime.Today.ToString("yy");
            }
        }

        private String MMM
        {
            get
            {
                return DateTime.Today.ToString("MMM");
            }
        }

        private String MM
        {
            get
            {
                return DateTime.Today.ToString("MM");
            }
        }

        private String DD
        {
            get
            {
                return DateTime.Today.ToString("dd");
            }
        }

        private String HH
        {
            get
            {
                return DateTime.Now.ToString("HH");
            }
        }

        private String NN
        {
            get
            {
                return DateTime.Now.ToString("mm");
            }
        }

        private String SS
        {
            get
            {
                return DateTime.Now.ToString("ss");
            }
        }

        private String TZ
        {
            get
            {
                return DateTime.Today.ToString("K");
            }
        }
    }
}

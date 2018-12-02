using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldProject
{
    class Father
    {
        List<string> states;
        List<string> actions;

        public string currentState;
        public string currentAction;
        
        public Father(List<string> states, List<string> actions)
        {
            this.states = states;
            this.actions = actions;

            currentState = states[0];
        }

        public void setState(string mark)
        {
            if (currentState == states[0]) {
                switch(mark)
                {
                    case "2":
                        currentState = states[1];
                        currentAction = actions[2];
                        break;
                    case "5":
                        currentState = states[3];
                        currentAction = actions[4];
                        break;
                }
            }

            else if (currentState == states[1])
            {
                switch (mark)
                {
                    case "2":
                        currentState = states[2];
                        currentAction = actions[1];
                        break;
                    case "5":
                        currentState = states[0];
                        currentAction = actions[3];
                        break;
                }
            }

            else if (currentState == states[2])
            {
                switch (mark)
                {
                    case "2":
                        currentState = states[2];
                        currentAction = actions[0];
                        break;
                    case "5":
                        currentState = states[0];
                        currentAction = actions[3];
                        break;
                }
            }

            else if (currentState == states[3])
            {
                switch (mark)
                {
                    case "2":
                        currentState = states[1];
                        currentAction = actions[2];
                        break;
                    case "5":
                        currentState = states[3];
                        currentAction = actions[5];
                        break;
                }
            }
        }
    }
}

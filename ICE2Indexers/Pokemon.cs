using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE2Indexers
{
    public class Pokemon
    {
        string name, type, ability, weaknesses;
        double weight, height;


        public Pokemon(string name, string type, string ability, string weaknesses, double weight, double height)
        {
            this.name = name;
            this.type = type;
            this.ability = ability;
            this.weaknesses = weaknesses;
            this.weight = weight;
            this.height = height;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.name;
                else if (index == 1)
                    return this.type;
                else if (index == 2)
                    return this.ability;
                else if (index == 3)
                    return this.weaknesses;
                else if (index == 4)
                    return this.weight;
                else if (index == 5)
                    return this.height;
                return null;
            }
            set
            {
                if (index == 0)
                    this.name = (string)value;
                else if (index == 1)
                    this.type = (string)value;
                else if (index == 2)
                    this.ability = (string)value;
                else if (index == 3)
                    this.weaknesses = (string)value;
                else if (index == 4)
                    this.weight = (double)value;
                else if (index == 5)
                    this.height = (double)value;
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName == "name")
                    return this.name;
                else if (attrName == "type")
                    return this.type;
                else if (attrName == "ability")
                    return this.ability;
                else if (attrName == "weaknesses")
                    return this.weaknesses;
                else if (attrName == "weight")
                    return this.weight;
                else if (attrName == "height")
                    return this.height;
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("name"))
                    this.name = (string)value;
                else if (attrName.ToLower().Equals("type"))
                    this.type = (string)value;
                else if (attrName.ToLower().Equals("ability"))
                    this.ability = (string)value;
                else if (attrName.ToLower().Equals("weaknesses"))
                    this.weaknesses = (string)value;
                else if (attrName.ToLower().Equals("weight"))
                    this.weight = (double)value;
                else if (attrName.ToLower().Equals("height"))
                    this.height = (double)value;
            }
        }
    }
}

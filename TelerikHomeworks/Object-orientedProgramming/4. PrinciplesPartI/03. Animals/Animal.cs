using System;

namespace _03.Animals
{
    abstract class Animal : ISound
    {
        private string name;
        private ushort age;
        private bool isMale;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        public ushort Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public bool IsMale
        {
            get
            {
                return this.isMale;
            }
            set
            {
                this.isMale = value;
            }
        }

        public abstract void Sound();
    }
}

namespace WinFormsApp1
{
    using System;
    using System.Collections;

    [Serializable]
    public enum AnimalType
    { Bird, Horse,Lion }

    [Serializable]
    public enum HorseBreed
    { Rainbow, Black, Brown, Twilight }

    [Serializable]
    public enum HorseSize
    { Regular, Pony }

    [Serializable]
    public enum BirdSize
    { Small,Big  }
    
    [Serializable]
    public enum BirdBreed
    { Chicken, Parrot, Ostrich, Penguin }

    [Serializable]
    public abstract class Animal
    {
        protected string _name_;
        protected int _speed_;
        protected int _lives_;
        protected AnimalType _animalType_;

        public string GetName()
        { return _name_; }
        public int GetSpeed()
        { return _speed_; }
        public int GetLives()
        { return _lives_; }
        public AnimalType GetType()
        { return _animalType_; }
    }

    [Serializable]
    public class Lion : Animal
    {
        public Lion(string name)
        {
            _name_ = name;
            _speed_ = 300;
            _lives_ = 100;
            _animalType_ = AnimalType.Lion;
        }
    }
    [Serializable]
    public class Bird : Animal
    {
        protected BirdBreed _breed_;

        public BirdBreed GetBreed()
        { return _breed_; }
    }

    [Serializable]
    public class Small : Bird
    {
        public Small(string name, BirdBreed breed)
        {
            _name_ = name;
            _speed_ = 30;
            _lives_ = 3;
            _breed_ = breed;
            _animalType_ = AnimalType.Bird;
        }
    }

    [Serializable]
    public class Big : Bird
    {
        public Big(string name, BirdBreed breed)
        {
            _name_ = name;
            _speed_ = 60;
            _lives_ = 5;
            _breed_ = breed;
            _animalType_ = AnimalType.Bird;
        }
    }


    [Serializable]
    public abstract class Horse : Animal
    {
        protected HorseBreed _breed_;

        public HorseBreed GetBreed()
        { return _breed_; }
    }

    [Serializable]
    public class Pony : Horse
    {
        public Pony(string name, HorseBreed breed)
        {
            _name_ = name;
            _speed_ = 50;
            _lives_ = 4;
            _breed_ = breed;
            _animalType_ = AnimalType.Horse;
        }
    }

    [Serializable]
    public class Regular : Horse
    {
        public Regular(string name, HorseBreed breed)
        {
            _name_ = name;
            _speed_ = 90;
            _lives_ = 5;
            _breed_ = breed;
            _animalType_ = AnimalType.Horse;
        }
    }

    [Serializable]
    public class AnimalList
    {
        protected SortedList animalList;

        public AnimalList()
        { animalList = new SortedList(); }
        public int NextIndex
        {
            get { return animalList.Count; }
        }

        public void Add(Animal animal)
        {
            animalList.Add(animal.GetName(), animal);
        }
        public void Remove(Animal animal)
        {
            animalList.Remove(animal.GetName());
        }

        public Animal this[int index]
        {
            get
            {
                if (index >= animalList.Count)
                    return (Animal)null;
                return (Animal)animalList.GetByIndex(index);
            }
            set
            {
                if (index <= animalList.Count)
                    animalList[index] = value;
            }
        }
    }
}

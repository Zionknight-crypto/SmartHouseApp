

namespace AlyTaloSovellus
{

    public class TermostaattiStatus
    {
      
        public string saunaOn;
        public int saunaTemp;

        public int getTemp()
        {
            return saunaTemp;
        }
        
        public bool taloOn;

        public bool getTalo()
        {
            return taloOn;
        }
        public void setTaloOnTrue()
        {
            taloOn = true;
        }
        public void setTaloOff()
        {
            taloOn = false;
        }
    }
}

        //The house temperature is controlled via the user interface
        //Data will be stored in Thermostat class created on the basis of category of object (this also creates a category defined)
        //method for setting the target house temperature
        //In addition, the class has a Temperature property(int) where the target temperature is stored
        //The interface has previous temperature(last set temperature).
        //Target temperature field(this is where the user enters a new value)
        //button to set the new target temperature is displayed in the current value field.
        //At the same time, the target temperature field is cleared.
        //Note that the text-based temperature value of the user interface needs to be converted to int when it is stored on the object, 
        //because Temperature is of the int type and vice versa when the object's int type value is displayed in the user interface
        //That is, one field is for displaying the current value and the other field for a new value.
        //When the new value is set by pressing the Set Temperature button, the target temperature is stored in the object and the value of the objec
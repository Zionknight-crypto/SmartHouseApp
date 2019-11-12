
namespace AlyTaloSovellus
{
    public class SaunaStatus
    {
        public bool saunaOn;

        public bool getSauna()
        {
            return saunaOn;
        }
        public void setSaunaOnTrue()
        {
            saunaOn = true;
        }
        public void setSaunaOff()
        {
            saunaOn = false;
        }

       
        //The temperature at which the current sauna temperature is stored

        //There is a text box in the user interface that says SAUNAS ON when the sauna is on.If the sauna is off, the field is empty.
        //When the sauna is turned off, the field is emptied.Alternatively, you can use a "lamp" to indicate when you are on the sauna.
        //When the sauna is turned on, the temperature of the sauna must increase by half a second (so the stove is quite effective ...). 
        //The temperature is applied to the object by a timer that is executed in the main program, which thus triggers once per second.
        //The interface displays the current temperature value known to the object.
        //Note! Increasing the temperature of the sauna starts with the basic temperature of the house(ie not zero!)
        //When the sauna is turned off, the temperature drops by one degree per second(effective cooling in the sauna). You can make another timer to lower the temperature.

    }
}

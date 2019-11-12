
namespace AlyTaloSovellus

{
    public class Valot
    {
        public bool valoOn;

        public bool getValo()
        {
            return valoOn;
        }
        public void setValoOnTrue()
        {
           valoOn = true;
        }
        public void setValoOff()
        {
            valoOn = false;
        }
        
        //Dimmer String to set the amount of dimming(0 = dark and 100 = full light)
        //The user interface has a slider to adjust the amount of light between 0 and 100. In addition, it has a text box that tells you the position of each luminaire(ie kitchen or living room) at any given time.
        //Note that the Switched object is false only when the lights are turned off (value = 0). Otherwise, Switched is always true, but Dimmer tells you how much light is given.

    }
}

using DesignPattern.StructuralPattern.Facade.ComplexComponents;
using DesignPattern.StructuralPattern.FacadePattern.Facade;

namespace DesignPattern.StructuralPattern.FacadePattern
{
    public class ConsumerClass
    {
        /*
         * 
         * The Facade Pattern is a structural design pattern that provides a simplified interface 
         * to a complex system of classes, libraries, or frameworks. 
         * It hides the complexity of the system and provides an easy-to-use interface for the client.
         * The goal of the Facade Pattern is to make it easier for clients to interact 
         * with a subsystem by simplifying interactions.
        */
        public void FacadeConsumer()
            {
                // Create subsystems
                Light light = new Light();
                Thermostat thermostat = new Thermostat();
                SecurityCamera securityCamera = new SecurityCamera();

                // Create the facade
                HomeAutomationFacade homeAutomation = new HomeAutomationFacade(light, thermostat, securityCamera);

                // Simplified interaction with the complex subsystems
                homeAutomation.LeaveHome();   // Output: Leaving home, Turning off lights, Setting thermostat, etc.
                Console.WriteLine();
                homeAutomation.ArriveHome();  // Output: Arriving home, Turning on lights, Adjusting thermostat, etc.
            }
    }
}

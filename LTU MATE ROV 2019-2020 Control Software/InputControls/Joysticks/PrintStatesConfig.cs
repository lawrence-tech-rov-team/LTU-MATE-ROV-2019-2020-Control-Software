using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoystickInput;
using LTU_MATE_ROV_2019_2020_Control_Software.Utils;

namespace LTU_MATE_ROV_2019_2020_Control_Software.InputControls.Joysticks {
	public class PrintStatesConfig : JoystickConfig {

		public override Twist Translate(Dictionary<JoystickControl, int> states) {
			Console.WriteLine(
				"Joystick States: [" +
				"\n	Buttons:" + 
				"\n		0:  {0}" + 
				"\n		1:  {1}" +
				"\n		2:  {2}" + 
				"\n		3:  {3}" +
				"\n		4:  {4}" +
				"\n		5:  {5}" +
				"\n		6:  {6}" +
				"\n		7:  {7}" +
				"\n		8:  {8}" +
				"\n		9:  {9}" +
				"\n	POV: {10}" + 
				"\n	Sliders: " + 
				"\n		0: {11}" +
				"\n		1: {12}" + 
				"\n	Axis: " +
				"\n		Linear: " + 
				"\n			x: {13}" +
				"\n			y: {14}" +
				"\n			z: {15}" +
				"\n		Rotational: " +
				"\n			x: {16}" +
				"\n			y: {17}" +
				"\n			z: {18}" +
				"\n]",
			states[JoystickControl.Buttons0],
			states[JoystickControl.Buttons1],
			states[JoystickControl.Buttons2],
			states[JoystickControl.Buttons3],
			states[JoystickControl.Buttons4],
			states[JoystickControl.Buttons5],
			states[JoystickControl.Buttons6],
			states[JoystickControl.Buttons7],
			states[JoystickControl.Buttons8],
			states[JoystickControl.Buttons9],
			states[JoystickControl.PointOfViewControllers0],
			states[JoystickControl.Sliders0],
			states[JoystickControl.Sliders1],
			states[JoystickControl.X],
			states[JoystickControl.Y],
			states[JoystickControl.Z],
			states[JoystickControl.RotationX],
			states[JoystickControl.RotationY],
			states[JoystickControl.RotationZ]
			);

			return new Twist();
		}

	}
}

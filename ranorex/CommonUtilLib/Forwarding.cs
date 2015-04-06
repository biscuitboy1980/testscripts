/*
 * Created by Ranorex
 * User: gguenther
 * Date: 1/27/2011
 * Time: 9:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
	
namespace CommonUtilLib
{
	/// <summary>
	/// Description of Forwarding.
	/// </summary>

	public class Forwarding
	{
		//************************************************************************************//
		//**************Link 16 to Link 11 Air, Surface and Space ID Conversion***************//
		//************************************************************************************//
		
		public void ConvertID_Air_Surface_Space(string Link16ID, out string L11ID, out string L11PriAmp)	
		{
			string Link11ID = "invalid";
			string Link11PriAmp = "invalid";
			
			switch (Link16ID)
			{					
				case "Pending":
				Link11ID = "Unknown";
				Link11PriAmp = "Pending";
				break;
								
				case "Unknown":
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				break;
								
				case "Assumed Friend":
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				break;
					
				case "Friend":
				case "Neutral":
				Link11ID = "Friend";
				Link11PriAmp = "General";
				break;
								
				case "Suspect":
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				break;
					
				case "Hostile":
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				break;
					
				default:
				Report.Error("ID could not be converted");
				break;
			}
			
			L11ID = Link11ID;
	    	L11PriAmp = Link11PriAmp;
		}
		
		//************************************************************************************//
		//********************Link 16 to Link 11 Subsurface ID Conversion*********************//
		//************************************************************************************//
		
		public string ConvertID_Subsurface(string Link16ID)	
		{
			string Link11ID = "invalid";
			
			switch (Link16ID)
			{					
				case "Pending":
				Link11ID = "Pending";
				break;
								
				case "Unknown":
				case "Assumed Friend":
				case "Suspect":
				Link11ID = "Unknown";
				break;
					
				case "Friend":
				case "Neutral":
				Link11ID = "Friend";
				break;
					
				case "Hostile":
				Link11ID = "Hostile";
				break;
					
				default:
				Report.Error("ID could not be converted");
				break;
			}
			
			return Link11ID;
		}
		
		//************************************************************************************//
		//***********************Link 16 to Link 11 Land ID Conversion************************//
		//************************************************************************************//		
		
		public string ConvertID_Land(string Link16ID)
		{
			string Link11Point = "invalid";
			
			switch (Link16ID)
			{					
				case "Pending":
				case "Unknown":
				case "Assumed Friend":
				case "Neutral":
				Link11Point = "REFERENCE POINT (GENERAL)";
				break;
								
				case "Suspect":
				case "Hostile":
				Link11Point = "ENEMY POINT";
				break;
					
				case "Friend":
				Link11Point = "SUPPORT UNIT (SU)";
				break;
					
				default:
				Report.Error("ID could not be converted");
				break;
			}
			
			return Link11Point;
		}				
	
		//************************************************************************************//
		//**************************Link 16 to Link 11 Air Conversion*************************//
		//************************************************************************************//		
		
		public void Convert_AirL16_L11(string Link16ID, string Link16Plat, string Link16Act, out string L11ID, out string L11PriAmp, out string L11IDAmp)
		{
			string Link11ID;
			string Link11PriAmp;
			string Link11IDAmp;
			bool Others = true;
			
			//*****************************ID PENDING****************************//
			
			if (Link16ID == "Pending" && Link16Plat != null && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Pending";
				Link11IDAmp = "N.S.";
				Others = false;
			}
			
			//*****************************ID UNKNOWN****************************//
			
			else if (Link16ID == "Unknown" && Link16Plat == "Bomber" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "Bomber";
				Others = false;
			}
			else if (Link16ID == "Unknown" && Link16Plat == "Fighter Bomber" && (Link16Act == "Minelaying" ||  
			                                                                     Link16Act == "Special Weapons Attack" || 
			                                                                     Link16Act == "Air Assault" || 
			                                                                     Link16Act == "Conventional Attack" || 
			                                                                     Link16Act == "Interdiction" || 
			                                                                     Link16Act == "Close Air Support (CAS)" || 
			                                                                     Link16Act == "Ground Attack Tactics (GAT)" || 
			                                                                     Link16Act == "Strike Warfare" || 
			                                                                     Link16Act == "Antisubmarine Warfare (ASW)"))
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "Bomber";
				Others = false;
			}					
			else if (Link16ID == "Unknown" && Link16Plat == "Attack" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "Bomber";
				Others = false;
			}				
			else if (Link16ID == "Unknown" && Link16Plat == "Fighter" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "Fighter";
				Others = false;
			}		
			else if (Link16ID == "Unknown" && Link16Plat == "Fighter Bomber" && (Link16Act != "Minelaying" ||  
			                                                                     Link16Act != "Special Weapons Attack" || 
			                                                                     Link16Act != "Air Assault" || 
			                                                                     Link16Act != "Conventional Attack" || 
			                                                                     Link16Act != "Interdiction" || 
			                                                                     Link16Act != "Close Air Support (CAS)" || 
			                                                                     Link16Act != "Ground Attack Tactics (GAT)" || 
			                                                                     Link16Act != "Strike Warfare" || 
			                                                                     Link16Act != "Antisubmarine Warfare (ASW)"))
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "Fighter";
				Others = false;
			}		
			else if (Link16ID == "Unknown" && Link16Plat == "Interceptor" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "Fighter";
				Others = false;
			}
			else if (Link16ID == "Unknown" && Link16Plat == "Airborne Early Warning and Control (AEW)" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "AEW/RECCE/EW/Decoy";	
				Others = false;
			}		
			else if (Link16ID == "Unknown" && (Link16Plat == "Airborne Command Post (ACP)" ||
			                                   Link16Plat == "Reconnaissance" ||
			                                   Link16Plat == "Electronic Warfare (EW)" ||
			                                   Link16Plat == "Maritime Patrol Aircraft (MPA)" ||
			                                   Link16Plat == "Decoy" ||
			                                   Link16Plat == "Patrol" ||
			                                   Link16Plat == "Airborne Land Surveillance")  && Link16Act != null)                                                            
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "AEW/RECCE/EW/Decoy";	
				Others = false;
			}					
			else if (Link16ID == "Unknown" && Link16Plat == "Helicopter (Helo)" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "Helo/Transport";	
				Others = false;
			}				
			else if (Link16ID == "Unknown" && (Link16Plat == "Attack Helicopter" ||
			                                   Link16Plat == "Helicopter Gunship" ||
			                                   Link16Plat == "Antisubmarine Warfare Helicopter (ASW Helo)" ||
			                                   Link16Plat == "Mine Warfare Helicopter" ||
			                                   Link16Plat == "Transport Helicopter")  && Link16Act != null)                                                            
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "Helo/Transport";		
				Others = false;
			}	
			else if (Link16ID == "Unknown" && Link16Plat == "Missile Control Unit" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "Missile Platform";	
				Others = false;
			}				
			else if (Link16ID == "Unknown" && (Link16Plat != "Bomber" ||
			                                   Link16Plat != "Fighter Bomber" ||
			                                   Link16Plat != "Attack" ||
			                                   Link16Plat != "Fighter" ||
			                                   Link16Plat != "Fighter Bomber" ||
			                                   Link16Plat != "Interceptor" ||
			                                   Link16Plat != "Airborne Early Warning and Control (AEW)" ||
			                                   Link16Plat != "Airborne Command Post (ACP)" ||
			                                   Link16Plat != "Reconnaissance" ||
			                                   Link16Plat != "Electronic Warfare (EW)" ||
			                                   Link16Plat != "Maritime Patrol Aircraft (MPA)" ||
			                                   Link16Plat != "Decoy" ||
			                                   Link16Plat != "Patrol" ||
			                                   Link16Plat != "Airborne Land Surveillance" ||
			                                   Link16Plat != "Helicopter (Helo)" ||
			                                   Link16Plat != "Attack Helicopter" ||
			                                   Link16Plat != "Helicopter Gunship" ||
			                                   Link16Plat != "Antisubmarine Warfare Helicopter (ASW Helo)" ||
			                                   Link16Plat != "Transport Helicopter" ||
			                                   Link16Plat == "Transport" ||
			                                   Link16Plat == "Missile Control Unit") && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "N.S.";			
				Others = false;
			}	
			
			//*****************************ID SUSPECT****************************//

			else if (Link16ID == "Suspect" && (Link16Plat == "Drone" ||
			                                   Link16Plat == "Remotely Piloted Vehicle (RPV)" ||
			                                   Link16Plat == "Unmanned Aerial Vehicle (UAV)") && Link16Act != null)
			{					
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Drone/RPV";	
				Others = false;
			}	
			else if (Link16ID == "Suspect" && Link16Plat == "Bomber" && Link16Act != "XRay")
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Bomber";	
				Others = false;
			}				
			else if (Link16ID == "Suspect" && Link16Plat == "Fighter Bomber" && (Link16Act == "Minelaying" ||  
			                                                                     Link16Act == "Special Weapons Attack" || 
			                                                                     Link16Act == "Air Assault" || 
			                                                                     Link16Act == "Conventional Attack" || 
			                                                                     Link16Act == "Interdiction" || 
			                                                                     Link16Act == "Close Air Support (CAS)" || 
			                                                                     Link16Act == "Ground Attack Tactics (GAT)" || 
			                                                                     Link16Act == "Strike Warfare" || 
			                                                                     Link16Act == "Antisubmarine Warfare (ASW)" ||
			                                                                     Link16Act == "Antisurface Warfare"))
			{	
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Bomber";		
				Others = false;
			}			
			else if (Link16ID == "Suspect" && Link16Plat == "Attack" && Link16Act != "XRay")
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Bomber";	
				Others = false;
			}			
			else if (Link16ID == "Suspect" && Link16Plat == "Fighter" && Link16Act != "XRay")
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Fighter";	
				Others = false;
			}	
			else if (Link16ID == "Suspect" && Link16Plat == "Fighter Bomber" && (Link16Act != "XRay" ||
																			     Link16Act != "Minelaying" ||
			                                                                     Link16Act != "Special Weapons Attack" || 
			                                                                     Link16Act != "Air Assault" || 
			                                                                     Link16Act != "Conventional Attack" || 
			                                                                     Link16Act != "Interdiction" || 
			                                                                     Link16Act != "Close Air Support (CAS)" || 
			                                                                     Link16Act != "Ground Attack Tactics (GAT)" || 
			                                                                     Link16Act != "Strike Warfare" || 
			                                                                     Link16Act != "Antisubmarine Warfare (ASW)" ||
			                                                                     Link16Act != "Antisurface Warfare"))
			{	
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Fighter";
				Others = false;
			}	
			else if (Link16ID == "Suspect" && Link16Plat == "Interceptor" && Link16Act != "XRay")
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Fighter";
				Others = false;
			}	
			else if (Link16ID == "Suspect" && Link16Plat == "Airborne Early Warning and Control (AEW)" && Link16Act != "XRay")
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "AEW/RECCE/EW/Decoy";	
				Others = false;
			}	
			else if (Link16ID == "Suspect" && (Link16Plat == "Airborne Command Post (ACP)" ||
			                                   Link16Plat == "Reconnaissance" ||
			                                   Link16Plat == "Electronic Warfare (EW)" ||
			                                   Link16Plat == "Maritime Patrol Aircraft (MPA)" ||
			                                   Link16Plat == "Decoy" ||
			                                   Link16Plat == "Patrol" ||
			                                   Link16Plat == "Airborne Land Surveillance") && Link16Act != "XRay")
			{					
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "AEW/RECCE/EW/Decoy";	
				Others = false;
			}				
			else if (Link16ID == "Suspect" && Link16Plat == "Helicopter (Helo)" && Link16Act != "XRay")
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Helo/Transport";	
				Others = false;
			}	
			else if (Link16ID == "Suspect" && (Link16Plat == "Attack Helicopter" ||
			                                   Link16Plat == "Helicopter Gunship" ||
			                                   Link16Plat == "Antisubmarine Warfare Helicopter (ASW HELO)" ||
			                                   Link16Plat == "Mine Warfare Helicopter" ||
			                                   Link16Plat == "Transport Helicopter" ||
			                                   Link16Plat == "Transport") && Link16Act != "XRay")
			{					
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Helo/Transport";		
				Others = false;
			}				
			else if (Link16ID == "Suspect" && Link16Plat == "Missile Control Unit" && Link16Act != "XRay")
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Missile Platform";
				Others = false;
			}				
			else if (Link16ID == "Suspect" && Link16Plat != null && Link16Act == "XRay")
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Xray/Intruder";	
				Others = false;
			}			
			else if (Link16ID == "Suspect" && Link16Plat != null && Link16Act != "XRay")
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "N.S.";	
				Others = false;
			}	
			//**************************ID ASSUMED FRIEND**************************//

			else if (Link16ID == "Assumed Friend" && Link16Plat == "Bomber" && Link16Act != null)                                                            
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "Bomber";			
				Others = false;
			}	
			else if (Link16ID == "Assumed Friend" && Link16Plat == "Fighter Bomber" && (Link16Act == "Minelaying" ||  
			                                                                     		Link16Act == "Special Weapons Attack" || 
			                                                                     		Link16Act == "Air Assault" || 
			                                                                     		Link16Act == "Conventional Attack" || 
			                                                                     		Link16Act == "Interdiction" || 
			                                                                    		Link16Act == "Close Air Support (CAS)" || 
			                                                                    		Link16Act == "Ground Attack Tactics (GAT)" || 
			                                                                     	    Link16Act == "Strike Warfare" || 
			                                                                     	    Link16Act == "Antisubmarine Warfare (ASW)" ||
			                                                                     	    Link16Act == "Antisurface Warfare"))
			{	
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "Bomber";		
				Others = false;
			}				
			else if (Link16ID == "Assumed Friend" && Link16Plat == "Attack" && Link16Act != null)                                                            
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "Bomber";	
				Others = false;
			}	
			else if (Link16ID == "Assumed Friend" && Link16Plat == "Fighter" && Link16Act != null)                                                            
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "Fighter";
				Others = false;
			}	
			else if (Link16ID == "Assumed Friend" && Link16Plat == "Fighter Bomber" && (Link16Act != "Minelaying" ||
			                                                                     		Link16Act != "Special Weapons Attack" || 
			                                                                     		Link16Act != "Air Assault" || 
			                                                                     		Link16Act != "Conventional Attack" || 
			                                                                     		Link16Act != "Interdiction" || 
			                                                                     		Link16Act != "Close Air Support (CAS)" || 
			                                                                     		Link16Act != "Ground Attack Tactics (GAT)" || 
			                                                                     		Link16Act != "Strike Warfare" || 
			                                                                    		Link16Act != "Antisubmarine Warfare (ASW)" ||
			                                                                     		Link16Act != "Antisurface Warfare"))
			{	
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "Fighter";
				Others = false;
			}	
			else if (Link16ID == "Assumed Friend" && Link16Plat == "Interceptor" && Link16Act != null)                                                            
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "Fighter";
				Others = false;
			}	
			else if (Link16ID == "Assumed Friend" && Link16Plat == "Airborne Early Warning and Control (AEW)" && Link16Act !=null)                                                            
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "AEW/RECCE/EW/Decoy";	
				Others = false;
			}	
			else if (Link16ID == "Assumed Friend" && (Link16Plat == "Airborne Command Post (ACP)" ||
			                                   		  Link16Plat == "Reconnaissance" ||
			                                          Link16Plat == "Electronic Warfare (EW)" ||
			                                          Link16Plat == "Maritime Patrol Aircraft (MPA)" ||
			                                          Link16Plat == "Decoy" ||
			                                          Link16Plat == "Patrol" ||
			                                          Link16Plat == "Airborne Land Surveillance") && Link16Act != null)
			{					
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "AEW/RECCE/EW/Decoy";	
				Others = false;
			}	
			else if (Link16ID == "Assumed Friend" && Link16Plat == "Helicopter (Helo)" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "Helo/Transport";		
				Others = false;
			}						
			else if (Link16ID == "Assumed Friend" && (Link16Plat == "Attack Helicopter" ||
			                                          Link16Plat == "Helicopter Gunship" ||
			                                          Link16Plat == "Antisubmarine Warfare Helicopter (ASW Helo)" ||
			                                          Link16Plat == "Mine Warfare Helicopter" ||
			                                          Link16Plat == "Transport Helicopter" ||
			                                          Link16Plat == "Transport") && Link16Act != null)
			{					
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "Helo/Transport";	
				Others = false;
			}				
			else if (Link16ID == "Assumed Friend" && Link16Plat == "Missile Control Unit" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "Missile Platform";
				Others = false;
			}				
			else if (Link16ID == "Assumed Friend" && (Link16Plat != "Bomber" ||
			                                   		  Link16Plat != "Fighter Bomber" ||
			                                          Link16Plat != "Attack" ||
			                                          Link16Plat != "Fighter" ||
			                                          Link16Plat != "Fighter Bomber" ||
			                                          Link16Plat != "Interceptor" ||
			                                          Link16Plat != "Airborne Early Warning and Control (AEW)" ||
			                                          Link16Plat != "Airborne Command Post (ACP)" ||
			                                          Link16Plat != "Reconnaissance" ||
			                                          Link16Plat != "Electronic Warfare (EW)" ||
			                                          Link16Plat != "Maritime Patrol Aircraft (MPA)" ||
			                                          Link16Plat != "Decoy" ||
			                                          Link16Plat != "Patrol" ||
			                                          Link16Plat != "Airborne Land Surveillance" ||
			                                          Link16Plat != "Helicopter (Helo)" ||
			                                          Link16Plat != "Attack Helicopter" ||
			                                          Link16Plat != "Helicopter Gunship" ||
			                                          Link16Plat != "Antisubmarine Warfare Helicopter (ASW Helo)" ||
			                                          Link16Plat != "Transport Helicopter" ||
			                                          Link16Plat == "Transport" ||
			                                          Link16Plat == "Missile Control Unit") && Link16Act !=null)  
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "N.S.";			
				Others = false;
			}	
			
			//*****************************ID HOSTILE*****************************//

			else if (Link16ID == "Hostile" && Link16Plat == "Missile" && Link16Act != null)                                                            
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Missile";	
				Others = false;
			}	
			else if (Link16ID == "Hostile" && (Link16Plat == "Surface-to-Air Missile (SAM)" ||
			                                   Link16Plat == "Air-to-Surface Missile (ASM)" ||
			                                   Link16Plat == "Surface-to-Surface Missile (SSM)" ||
			                                   Link16Plat == "Air-to-Air Missile (AAM)" ||
			                                   Link16Plat == "Subsurface-to-Surface Missile" ||
			                                   Link16Plat == "Surface-to-Subsurface Missile" ||
			                                   Link16Plat == "Cruise Missile" ||
			                                   Link16Plat == "Ballistic Missile" ||
			                                   Link16Plat == "Drone" ||
			                                   Link16Plat == "Remotely Piloted Vehicle (RPV)" ||
			                                   Link16Plat == "Unmanned Aerial Vehicle (UAV)")  && Link16Act !=null)
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Missile";		
				Others = false;
			}	
			else if (Link16ID == "Hostile" && Link16Plat == "Bomber" && Link16Act != "Jammer")                                                            
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Bomber";	
				Others = false;
			}	
			else if (Link16ID == "Hostile" && Link16Plat == "Fighter Bomber" && (Link16Act == "Minelaying" ||  
			                                                                     Link16Act == "Special Weapons Attack" || 
			                                                                     Link16Act == "Air Assault" || 
			                                                                     Link16Act == "Conventional Attack" || 
			                                                                     Link16Act == "Interdiction" || 
			                                                                     Link16Act == "Close Air Support (CAS)" || 
			                                                                     Link16Act == "Ground Attack Tactics (GAT)" || 
			                                                                     Link16Act == "Strike Warfare" || 
			                                                                     Link16Act == "Antisubmarine Warfare (ASW)" ||
			                                                                     Link16Act == "Antisurface Warfare"))
			{	
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Bomber";		
				Others = false;
			}				
			else if (Link16ID == "Hostile" && Link16Plat == "Attack" && Link16Act != "Jammer")                                                            
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Bomber";			
				Others = false;
			}	
			else if (Link16ID == "Hostile" && Link16Plat == "Fighter" && Link16Act != "Jammer")                                                            
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Fighter";	
				Others = false;
			}	
			else if (Link16ID == "Hostile" && Link16Plat == "Fighter Bomber" && (Link16Act != "Jammer" ||
																			     Link16Act != "Minelaying" ||
			                                                                     Link16Act != "Special Weapons Attack" || 
			                                                                     Link16Act != "Air Assault" || 
			                                                                     Link16Act != "Conventional Attack" || 
			                                                                     Link16Act != "Interdiction" || 
			                                                                     Link16Act != "Close Air Support (CAS)" || 
			                                                                     Link16Act != "Ground Attack Tactics (GAT)" || 
			                                                                     Link16Act != "Strike Warfare" || 
			                                                                     Link16Act != "Antisubmarine Warfare (ASW)" ||
			                                                                     Link16Act != "Antisurface Warfare"))
			{	
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Fighter";	
				Others = false;
			}	
			else if (Link16ID == "Hostile" && Link16Plat == "Interceptor" && Link16Act != "Jammer")                                                            
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Fighter";
				Others = false;
			}	
			else if (Link16ID == "Hostile" && Link16Plat == "Airborne Early Warning and Control (AEW)" && Link16Act != "Jammer")                                                            
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "AEW/RECCE/EW/Decoy";
				Others = false;
			}	
			else if (Link16ID == "Hostile" && (Link16Plat == "Airborne Command Post (ACP)" ||
			                                   Link16Plat == "Reconnaissance" ||
			                                   Link16Plat == "Electronic Warfare (EW)" ||
			                                   Link16Plat == "Maritime Patrol Aircraft (MPA)" ||
			                                   Link16Plat == "Decoy" ||
			                                   Link16Plat == "Patrol" ||
			                                   Link16Plat == "Airborne Land Surveillance") && Link16Act != "Jammer")
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "AEW/RECCE/EW/Decoy";	
				Others = false;
			}	
			else if (Link16ID == "Hostile" && Link16Plat == "Helicopter (Helo)" && Link16Act != "Jammer")
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Helo/Transport";		
				Others = false;
			}		
			else if (Link16ID == "Hostile" && (Link16Plat == "Attack Helicopter" ||
			                                   Link16Plat == "Helicopter Gunship" ||
			                                   Link16Plat == "Antisubmarine Warfare Helicopter (ASW Helo)" ||
			                                   Link16Plat == "Mine Warfare Helicopter" ||
			                                   Link16Plat == "Transport Helicopter" ||
			                                   Link16Plat == "Transport") && Link16Act != "Jammer")
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Helo/Transport";	
				Others = false;
			}		
			else if (Link16ID == "Hostile" && Link16Plat == "Missile Control Unit" && Link16Act != "Jammer")
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Missile Platform";	
				Others = false;
			}			
			else if (Link16ID == "Hostile" && Link16Plat != null && Link16Act == "Jammer")
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Jammer";			
				Others = false;
			}					
			else if (Link16ID == "Hostile" && (Link16Plat != "Bomber" ||
			                                   Link16Plat != "Fighter Bomber" ||
			                                   Link16Plat != "Attack" ||
			                                   Link16Plat != "Fighter" ||
			                                   Link16Plat != "Fighter Bomber" ||
			                                   Link16Plat != "Interceptor" ||
			                                   Link16Plat != "Airborne Early Warning and Control (AEW)" ||
			                                   Link16Plat != "Airborne Command Post (ACP)" ||
			                                   Link16Plat != "Reconnaissance" ||
			                                   Link16Plat != "Electronic Warfare (EW)" ||
			                                   Link16Plat != "Maritime Patrol Aircraft (MPA)" ||
			                                   Link16Plat != "Decoy" ||
			                                   Link16Plat != "Patrol" ||
			                                   Link16Plat != "Airborne Land Surveillance" ||
			                                   Link16Plat != "Helicopter (Helo)" ||
			                                   Link16Plat != "Attack Helicopter" ||
			                                   Link16Plat != "Helicopter Gunship" ||
			                                   Link16Plat != "Antisubmarine Warfare Helicopter (ASW HELO)" ||
			                                   Link16Plat != "Transport Helicopter" ||
			                                   Link16Plat == "Transport" ||
			                                   Link16Plat == "Missile Control Unit") && Link16Act != "Jammer")  
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "N.S.";			
				Others = false;
			}	
			
			//*****************************ID NEUTRAL****************************//
			
			else if (Link16ID == "Neutral" && Link16Plat != null && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "General";
				Link11IDAmp = "Neutral";
				Others = false;
			}

			//*****************************ID FRIEND*****************************//

			else if (Link16ID == "Friend" && Link16Plat == "Civil, Airliner" && Link16Act != null)                                                            
			{				
				Link11ID = "Friend";
				Link11PriAmp = "General";
				Link11IDAmp = "Nonmil";	
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Civil, General" && Link16Act != null)                                                            
			{				
				Link11ID = "Friend";
				Link11PriAmp = "General";
				Link11IDAmp = "Nonmil";		
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Missile" && Link16Act != null)                                                            
			{				
				Link11ID = "Friend";
				Link11PriAmp = "General";
				Link11IDAmp = "Missile";
				Others = false;
			}	
			else if (Link16ID == "Friend" && (Link16Plat == "Surface-to-Air Missile (SAM)" ||
			                                  Link16Plat == "Air-to-Surface Missile (ASM)" ||
			                                  Link16Plat == "Surface-to-Surface Missile (SSM)" ||
			                                  Link16Plat == "Air-to-Air Missile (AAM)" ||
			                                  Link16Plat == "Subsurface-to-Surface Missile" ||
			                                  Link16Plat == "Surface-to-Subsurface Missile" ||
			                                  Link16Plat == "Cruise Missile" ||
			                                  Link16Plat == "Ballistic Missile" ||
			                                  Link16Plat == "Drone" ||
			                                  Link16Plat == "Remotely Piloted Vehicle (RPV)" ||
			                                  Link16Plat == "Unmanned Aerial Vehicle (UAV)")  && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "General";
				Link11IDAmp = "Missile";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && (Link16Plat != "Fighter" ||
			                                  Link16Plat != "Fighter/Bomber" ||
			                                  Link16Plat != "Interceptor with RTB")  && Link16Act == "Return to Base (RTB)")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "General";
				Link11IDAmp = "RTB";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && (Link16Plat == "Helicopter (HELO)" || Link16Plat == "Mine Warfare Helicopter") && (Link16Act != "Antisubmarine Warfare (ASW)" ||
																			    												Link16Act != "Dipping" ||
			                                                                 													Link16Act != "Search and Rescue (SAR)" || 
															                                                                    Link16Act != "Reconnaissance" || 
															                                                                    Link16Act != "Surveillance" || 
															                                                                    Link16Act != "Patrol (Ocean Surveillance)" || 
															                                                                    Link16Act != "Search" || 
															                                                                    Link16Act != "Logistics Support" || 
															                                                                    Link16Act != "Airlift (Transport)" || 
															                                                                    Link16Act != "Trooplift" ||
															                                                                    Link16Act != "Air Assault" ||
															                                                                    Link16Act != "Medical Evacuation (MEDEVAC)"))
			{	
				Link11ID = "Friend";
				Link11PriAmp = "Helo";
				Link11IDAmp = "N.S.";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Antisubmarine Warfare Helicopter (ASW HELO)" && Link16Act != null)                                                            
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Helo";
				Link11IDAmp = "ASW";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Helicopter (HELO)" && (Link16Act == "Antisubmarine Warfare (ASW)" || Link16Act == "Dipping"))
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Helo";
				Link11IDAmp = "ASW";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Helicopter (HELO)" && Link16Act == "Search and Rescue (SAR)")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Helo";
				Link11IDAmp = "SAR";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && (Link16Plat == "Helicopter Gunship" || Link16Plat == "Attack Helicopter") && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Helo";
				Link11IDAmp = "Gun Ship";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Helicopter (HELO)" && (Link16Act == "Reconnaissance" ||
			                                                                       Link16Act == "Surveillance" ||
			                                                                       Link16Act == "Patrol (Ocean Surveillance)" ||
			                                                                       Link16Act == "Search"))
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Helo";
				Link11IDAmp = "RECON/RECCE";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Transport Helicopter" && (Link16Act == "Logistics Support" || Link16Act == "Airlift (Transport)"))
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Helo";
				Link11IDAmp = "Logistic";	
				Others = false;
				
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Transport Helicopter" && (Link16Act == "Trooplift" || Link16Act == "Air Assault"))
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Helo";
				Link11IDAmp = "Trooplift";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Transport Helicopter" && (Link16Act == "Medical Evacuation (MEDEVAC)"))
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Helo";
				Link11IDAmp = "MEDEVAC";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Bomber" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Strike/Support/Bomber";
				Link11IDAmp = "N.S.";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && (Link16Plat == "Attack" || Link16Plat == "Missile Control Unit" || Link16Plat == "Fixed Wing Gunship") && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Strike/Support/Bomber";
				Link11IDAmp = "N.S.";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Tactical Support" && (Link16Act != "ASW" ||
			                                                                      Link16Act != "CAS" ||
			                                                                      Link16Act != "Logistics" ||
			                                                                      Link16Act != "Support" ||
			                                                                      Link16Act != "Interdiction"))
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Strike/Support/Bomber";
				Link11IDAmp = "N.S.";			
				Others = false;
			}
			else if (Link16ID == "Friend" && Link16Plat == "Fighter Bomber" && (Link16Act == "Minelaying" ||  
			                                                                    Link16Act == "Special Weapons Attack" || 
			                                                                    Link16Act == "Air Assault" || 
			                                                                    Link16Act == "Conventional Attack" || 			                                                                    
			                                                                    Link16Act == "Strike Warfare" || 
			                                                                    Link16Act == "Antisubmarine Warfare (ASW)" ||
			                                                                    Link16Act == "Antisurface Warfare"))
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Strike/Support/Bomber";
				Link11IDAmp = "N.S.";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Antisubmarine Warfare (ASW)" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Strike/Support/Bomber";
				Link11IDAmp = "N.S.";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Maritime Patrol Aircraft (MPA)" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Strike/Support/Bomber";
				Link11IDAmp = "N.S.";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && !Link16Plat.Contains("HELO") && Link16Act == "Antisubmarine Warfare (ASW)")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Strike/Support/Bomber";
				Link11IDAmp = "N.S.";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Tanker" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Strike/Support/Bomber";
				Link11IDAmp = "Tanker (General)";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Tanker (Boom Only)" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Strike/Support/Bomber";
				Link11IDAmp = "Tanker (Boom)";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Tanker (Drogue Only)" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Strike/Support/Bomber";
				Link11IDAmp = "Tanker (Drogue)";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Tactical Support" && Link16Act == "Close Air Support (CAS)")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Strike/Support/Bomber";
				Link11IDAmp = "CAS/DAS";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Logistic" && Link16Act == "Logistics Support")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Strike/Support/Bomber";
				Link11IDAmp = "Logistic";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Transport" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Strike/Support/Bomber";
				Link11IDAmp = "Logistic";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat != null && Link16Act == "Logistics Support")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Strike/Support/Bomber";
				Link11IDAmp = "Logistic";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat != null && Link16Act == "Interdiction")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Strike/Support/Bomber";
				Link11IDAmp = "Interdiction";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && (Link16Plat == "Fighter" || Link16Plat == "Interceptor" || Link16Plat == "Fighter Bomber") && (Link16Act != "Return to Base (RTB)" ||
			                                                                                                                                Link16Act != "Rescue Combat Air Patrol (RESCAP)" ||
			                                                                                                                                Link16Act != "Combat Air Patrol (CAP)" ||
			                                                                                                                                Link16Act != "Antisubmarine Warfare (ASW)" ||
			                                                                                                                                Link16Act != "LOGISTICS" ||
			                                                                                                                                Link16Act != "SUPPORT" ||
			                                                                                                                                Link16Act != "INTERDICTION"))
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Int/Fighter";
				Link11IDAmp = "N.S.";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && !Link16Plat.Contains("HELO") && Link16Act == "Rescue Combat Air Patrol (RESCAP)")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Int/Fighter";
				Link11IDAmp = "RESCAP";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && !Link16Plat.Contains("HELO") && Link16Act == "Combat Air Patrol (CAP)")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Int/Fighter";
				Link11IDAmp = "CAP";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && (Link16Plat == "Fighter" || Link16Plat == "Interceptor" || Link16Plat == "Fighter Bomber") && Link16Act == "Return to Base (RTB)")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Int/Fighter";
				Link11IDAmp = "RTB";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && (Link16Plat == "Drone" || Link16Plat == "Remotely Piloted Vehicle (RPV)" || Link16Plat == "Unmanned Aerial Vehicle (UAV)") && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Int/Fighter";
				Link11IDAmp = "Drone/RPV";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && (Link16Plat == "Airborne Early Warning and Control (AEW)" || Link16Plat == "Airborne Command Post (ACP)" || Link16Plat == "Airborne Land Surveillance") && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "AEW/ARP/ABCCC";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat != null && (Link16Act == "Communications Relay" ||
			                                                        Link16Act == "Airborne Early Warning (AEW)" ||
			                                                        Link16Act == "Airborne Command Post (ACP)" ||
			                                                        Link16Act == "Command and Control" ))
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "AEW/ARP/ABCCC";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Search and Rescue (SAR)" && Link16Act == "Search and Rescue (SAR)")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "SAR";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && !Link16Plat.Contains("HELO") && Link16Act == "Search and Rescue (SAR)")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "SAR";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Electronic Warfare" && Link16Act == "Search and Rescue (SAR)")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "EW";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat != null && (Link16Act == "Electronic Warfare (EW)" ||
			                                                        Link16Act == "Electronic Warfare Support (ES)" ||
			                                                        Link16Act == "Electronic Attack (EA)" ||
			                                                        Link16Act == "Jammer" ||
			                                                        Link16Act == "Chaff Laying" ||
			                                                        Link16Act == "Electronic Protection (EP"))
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "EW";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && (Link16ID == "Reconnaissance" || Link16ID == "Patrol") && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "Recon/RECCE";			
				Others = false;
			}	
			else if (Link16ID == "Friend" && !Link16Plat.Contains("HELO") && (Link16Act == "Reconnaissance" ||			                                                                 																Link16Act == "Reconnaissance" ||
			         														  Link16Act == "Surveillance" ||
			         														  Link16Act == "Patrol (Ocean Surveillance)" ||
			         														  Link16Act == "Policing" ||
			         														  Link16Act == "Search"))
			{				     
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "SAR";			
				Others = false;
			}	
			else if (Others == true)
			{
				Link11ID = "Friend";
				Link11PriAmp = "General";
				Link11IDAmp = "N.S.";					
			}
			else
			{
				Link11ID = "Invalid";
				Link11PriAmp = "Invalid";
				Link11IDAmp = "Invalid";
			}
	
			L11ID = Link11ID;
			L11PriAmp = Link11PriAmp;
			L11IDAmp = Link11IDAmp;
		}	
	
		//************************************************************************************//
		//************************Link 16 to Link 11 Surface Conversion***********************//
		//************************************************************************************//		
		
		public void Convert_SurfaceL16_L11(string Link16ID, string Link16Plat, string Link16Act, out string L11ID, out string L11PriAmp, out string L11IDAmp)
		{
			string Link11ID;
			string Link11PriAmp;
			string Link11IDAmp;
			bool Others = true;
			
			//*****************************ID PENDING****************************//
			
			if (Link16ID == "Pending" && Link16Plat != null && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Pending";
				Link11IDAmp = "N.S.";
				Others = false;
			}
			
			//*****************************ID UNKNOWN****************************//
			
			else if (Link16ID == "Unknown" && Link16Plat == "Aircraft Carrier" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "Aircraft Carrier";
				Others = false;
			}
			
			else if (Link16ID == "Unknown" && Link16Plat == "Cruiser" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "CG/DD";
				Others = false;
			}		
			else if (Link16ID == "Unknown" && (Link16Plat == "Battleship" ||
			                                   Link16Plat == "Destroyer" ||
			                                   Link16Plat == "Frigate")  && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "CG/DD";
				Others = false;
			}		
			else if (Link16ID == "Unknown" && Link16Plat == "Fast Patrol Boat" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "PB/PG";
				Others = false;
			}				
			else if (Link16ID == "Unknown" && Link16Plat == "Amphibious" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "Amphibious";
				Others = false;
			}					
			else if (Link16ID == "Unknown" && (Link16Plat == "LHA/LHD" ||
			                                  Link16Plat == "Amphibious Assault Command Ship (LCC)" ||
			                                  Link16Plat == "Landing Craft (LC)" ||
			                                  Link16Plat == "Landing Platform" ||
			                                  Link16Plat == "Landing Ship" ||
			                                  Link16Plat == "Amphibious General Assault")  && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "Amphibious";
				Others = false;
			}				
			else if (Link16ID == "Unknown" && Link16Plat != null&& Link16Act == "Amphibious Warfare")
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "Amphibious";
				Others = false;
			}				
			else if (Link16ID == "Unknown" && Link16Plat == "Non-Military" && Link16Act !=null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "Nonmil";
				Others = false;
			}				
			else if (Link16ID == "Unknown" && (Link16Plat == "Hospital Ship" ||
			                                   Link16Plat == "Survey Vessel" ||
			                                   Link16Plat == "Ocean Research" ||
			                                   Link16Plat == "Fishing Vessel" ||
			                                   Link16Plat == "Merchant Vessel")  && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "Nonmil";
				Others = false;
			}				
			else if (Link16ID == "Unknown" && Link16Plat != null && (Link16Act == "Fishing" ||			                                                                 																Link16Act == "Reconnaissance" ||			         
			         												 Link16Act == "Noncombatant Operations"))
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "Nonmil";
				Others = false;
			}				
			else if (Link16ID == "Unknown" && Link16Plat == "Surfaced Submarine" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "Surfaced Submarine";
				Others = false;
			}	
			else if (Link16ID == "Unknown" && Link16Plat == "Intelligence Collector" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "SIGINT";
				Others = false;
			}			
			else if (Link16ID == "Unknown" && Link16Plat != null && (Link16Act == "Electronic Warfare (EW)" ||		
			                                                         Link16Act == "Intelligence Collecting" ||	
			                                                         Link16Act == "Electronic Warfare Support (ES)" ||	
			         												 Link16Act == "Electronic Attack (EA)"))
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "SIGINT";
				Others = false;
			}				
			else if (Link16ID == "Unknown" && (Link16Plat != "Aircraft Carrier" ||
			                                   Link16Plat != "Cruiser" ||
			                                   Link16Plat != "Battleship" ||
			                                   Link16Plat != "Destroyer" ||
			                                   Link16Plat != "Frigate" ||
			                                   Link16Plat != "Fast Patrol Boat" ||
			                                   Link16Plat != "Amphibious" ||
			                                   Link16Plat != "LHA/LHD" ||
			                                   Link16Plat != "Amphibious Assault Command Ship (LCC)" ||
			                                   Link16Plat != "Landing Craft (LC)" ||
			                                   Link16Plat != "Landing Platform" ||
			                                   Link16Plat != "Landing Ship" ||
			                                   Link16Plat != "Amphibious General Assault" ||
			                                   Link16Plat != "Non-Military" ||
			                                   Link16Plat != "Hospital Ship" ||
			                                   Link16Plat != "Survey Vessel" ||
			                                   Link16Plat != "Ocean Research" ||
			                                   Link16Plat != "Fishing Vessel" ||
			                                   Link16Plat != "Merchant Vessel" ||
			                                   Link16Plat != "Intelligence Collector" ||
			                                   Link16Plat == "Surfaced Submarine") && Link16Act != null)  
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "N.S.";			
				Others = false;
			}	
			
			//*****************************ID ASSUMED FRIEND****************************//
			
			else if (Link16ID == "Assumed Friend" && Link16Plat == "Aircraft Carrier" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "Aircraft Carrier";
				Others = false;
			}
			
			else if (Link16ID == "Assumed Friend" && Link16Plat == "Cruiser" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "CG/DD";
				Others = false;
			}		
			else if (Link16ID == "Assumed Friend" && (Link16Plat == "Battleship" ||
			                                   		  Link16Plat == "Destroyer" ||
			                                  		  Link16Plat == "Frigate")  && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "CG/DD";
				Others = false;
			}		
			else if (Link16ID == "Assumed Friend" && Link16Plat == "Fast Patrol Boat" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "PB/PG";
				Others = false;
			}				
			else if (Link16ID == "Assumed Friend" && Link16Plat == "Amphibious" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "Amphibious";
				Others = false;
			}					
			else if (Link16ID == "Assumed Friend" && (Link16Plat == "LHA/LHD" ||
			                                 		  Link16Plat == "Amphibious Assault Command Ship (LCC)" ||
			                                 		  Link16Plat == "Landing Craft (LC)" ||
			                                		  Link16Plat == "Landing Platform" ||
			                                		  Link16Plat == "Landing Ship" ||
			                               			  Link16Plat == "Amphibious General Assault")  && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "Amphibious";
				Others = false;
			}				
			else if (Link16ID == "Assumed Friend" && Link16Plat != null&& Link16Act == "Amphibious Warfare")
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "Amphibious";
				Others = false;
			}				
			else if (Link16ID == "Assumed Friend" && Link16Plat == "Non-Military" && Link16Act !=null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "Nonmil";
				Others = false;
			}				
			else if (Link16ID == "Assumed Friend" && (Link16Plat == "Hospital Ship" ||
			                                  		  Link16Plat == "Survey Vessel" ||
			                                  		  Link16Plat == "Ocean Research" ||
			                                  		  Link16Plat == "Fishing Vessel" ||
			                                 		  Link16Plat == "Merchant Vessel")  && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "Nonmil";
				Others = false;
			}				
			else if (Link16ID == "Assumed Friend" && Link16Plat != null && (Link16Act == "Fishing" ||			                                                                 																Link16Act == "Reconnaissance" ||			         
			         													    Link16Act == "Noncombatant Operations"))
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "Nonmil";
				Others = false;
			}				
			else if (Link16ID == "Assumed Friend" && Link16Plat == "Surfaced Submarine" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "Surfaced Submarine";
				Others = false;
			}	
			else if (Link16ID == "Assumed Friend" && Link16Plat == "Intelligence Collector" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "SIGINT";
				Others = false;
			}			
			else if (Link16ID == "Assumed Friend" && Link16Plat != null && (Link16Act == "Electronic Warfare (EW)" ||		
			                                                       		    Link16Act == "Intelligence Collecting" ||	
			                                                       			Link16Act == "Electronic Warfare Support (ES)" ||	
			         												 		Link16Act == "Electronic Attack (EA)"))
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "SIGINT";
				Others = false;
			}				
			else if (Link16ID == "Assumed Friend" && (Link16Plat != "Aircraft Carrier" ||
			                                   		  Link16Plat != "Cruiser" ||
			                                  	      Link16Plat != "Battleship" ||
			                              		      Link16Plat != "Destroyer" ||
			                               			  Link16Plat != "Frigate" ||
			                                    	  Link16Plat != "Fast Patrol Boat" ||
			                                   		  Link16Plat != "Amphibious" ||
			                                 		  Link16Plat != "LHA/LHD" ||
			                                  		  Link16Plat != "Amphibious Assault Command Ship (LCC)" ||
			                                 		  Link16Plat != "Landing Craft (LC)" ||
			                                  		  Link16Plat != "Landing Platform" ||
			                                  		  Link16Plat != "Landing Ship" ||
			                                  		  Link16Plat != "Amphibious General Assault" ||
			                                  		  Link16Plat != "Non-Military" ||
			                                  		  Link16Plat != "Hospital Ship" ||
			                                  		  Link16Plat != "Survey Vessel" ||
			                                  		  Link16Plat != "Ocean Research" ||
			                                  		  Link16Plat != "Fishing Vessel" ||
			                                  		  Link16Plat != "Merchant Vessel" ||
			                                 		  Link16Plat != "Intelligence Collector" ||
			                                  		  Link16Plat == "Surfaced Submarine") && Link16Act != null)  
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "N.S.";			
				Others = false;
			}				

			//******************************ID SUSPECT*****************************//
			
			else if (Link16ID == "Suspect" && Link16Plat == "Aircraft Carrier" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Aircraft Carrier";
				Others = false;
			}
			else if (Link16ID == "Suspect" && (Link16Plat == "Battleship" ||
			                                   Link16Plat == "Destroyer" ||
			                                   Link16Plat == "Frigate")  && Link16Act != null)
			{				
				Link11ID = "Suspect";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "CG/DD";
				Others = false;
			}		
			else if (Link16ID == "Suspect" && Link16Plat == "Fast Patrol Boat" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "PB/PG";
				Others = false;
			}				
			else if (Link16ID == "Suspect" && Link16Plat == "Amphibious" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Amphibious";
				Others = false;
			}					
			else if (Link16ID == "Suspect" && (Link16Plat == "LHA/LHD" ||
			                                   Link16Plat == "Amphibious Assault Command Ship (LCC)" ||
			                                   Link16Plat == "Landing Craft (LC)" ||
			                                   Link16Plat == "Landing Platform" ||
			                                   Link16Plat == "Landing Ship" ||
			                                   Link16Plat == "Amphibious General Assault")  && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Amphibious";
				Others = false;
			}				
			else if (Link16ID == "Suspect" && Link16Plat != null && Link16Act == "Amphibious Warfare")
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Amphibious";
				Others = false;
			}				
			else if (Link16ID == "Suspect" && Link16Plat == "Non-Military" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Nonmil";
				Others = false;
			}				
			else if (Link16ID == "Suspect" && (Link16Plat == "Hospital Ship" ||
			                                   Link16Plat == "Survey Vessel" ||
			                                   Link16Plat == "Ocean Research" ||
			                                   Link16Plat == "Fishing Vessel" ||
			                                   Link16Plat == "Merchant Vessel")  && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Nonmil";
				Others = false;
			}				
			else if (Link16ID == "Suspect" && Link16Plat != null && (Link16Act == "Fishing" ||			                                                                 																Link16Act == "Reconnaissance" ||			         
			         												 Link16Act == "Noncombatant Operations"))
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Nonmil";
				Others = false;
			}				
			else if (Link16ID == "Suspect" && Link16Plat == "Surfaced Submarine" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "Surfaced Submarine";
				Others = false;
			}	
			else if (Link16ID == "Suspect" && Link16Plat == "Intelligence Collector" && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "SIGINT";
				Others = false;
			}			
			else if (Link16ID == "Suspect" && Link16Plat != null && (Link16Act == "Electronic Warfare (EW)" ||		
			                                                         Link16Act == "Intelligence Collecting" ||	
			                                                         Link16Act == "Electronic Warfare Support (ES)" ||	
			         												 Link16Act == "Electronic Attack (EA)"))
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "SIGINT";
				Others = false;
			}	
			else if (Link16ID == "Suspect" && (Link16Plat != "Aircraft Carrier" ||
				                               Link16Plat != "Cruiser" ||
				                               Link16Plat != "Battleship" ||
				                               Link16Plat != "Destroyer" ||
				                               Link16Plat != "Frigate" ||
				                               Link16Plat != "Fast Patrol Boat" ||
				                               Link16Plat != "Amphibious" ||
				                               Link16Plat != "LHA/LHD" ||
				                               Link16Plat != "Amphibious Assault Command Ship (LCC)" ||
				                               Link16Plat != "Landing Craft (LC)" ||
				                               Link16Plat != "Landing Platform" ||
				                               Link16Plat != "Landing Ship" ||
				                               Link16Plat != "Amphibious General Assault" ||
				                               Link16Plat != "Non-Military" ||
				                               Link16Plat != "Hospital Ship" ||
				                               Link16Plat != "Survey Vessel" ||
				                               Link16Plat != "Ocean Research" ||
				                               Link16Plat != "Fishing Vessel" ||
				                               Link16Plat != "Merchant Vessel" ||
				                               Link16Plat != "Intelligence Collector" ||
				                               Link16Plat != "Surfaced Submarine") && Link16Act != null)  
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "N.S.";			
				Others = false;
			}	

			//******************************ID HOSTILE*****************************//
			
			else if (Link16ID == "Hostile" && Link16Plat == "Aircraft Carrier" && Link16Act != null)
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Aircraft Carrier";
				Others = false;
			}
			else if (Link16ID == "Hostile" && (Link16Plat == "Battleship" ||
			                                   Link16Plat == "Destroyer" ||
			                                   Link16Plat == "Frigate")  && Link16Act != null)
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "CG/DD";
				Others = false;
			}		
			else if (Link16ID == "Hostile" && Link16Plat == "Fast Patrol Boat" && Link16Act != null)
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "PB/PG";
				Others = false;
			}				
			else if (Link16ID == "Hostile" && Link16Plat == "Amphibious" && Link16Act != null)
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Amphibious";
				Others = false;
			}					
			else if (Link16ID == "Hostile" && (Link16Plat == "LHA/LHD" ||
			                                   Link16Plat == "Amphibious Assault Command Ship (LCC)" ||
			                                   Link16Plat == "Landing Craft (LC)" ||
			                                   Link16Plat == "Landing Platform" ||
			                                   Link16Plat == "Landing Ship" ||
			                                   Link16Plat == "Amphibious General Assault")  && Link16Act != null)
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Amphibious";
				Others = false;
			}				
			else if (Link16ID == "Hostile" && Link16Plat != null && Link16Act == "Amphibious Warfare")
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Amphibious";
				Others = false;
			}				
			else if (Link16ID == "Hostile" && Link16Plat == "Non-Military" && Link16Act != null)
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Nonmil";
				Others = false;
			}				
			else if (Link16ID == "Hostile" && (Link16Plat == "Hospital Ship" ||
			                                   Link16Plat == "Survey Vessel" ||
			                                   Link16Plat == "Ocean Research" ||
			                                   Link16Plat == "Fishing Vessel" ||
			                                   Link16Plat == "Merchant Vessel")  && Link16Act != null)
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Nonmil";
				Others = false;
			}				
			else if (Link16ID == "Hostile" && Link16Plat != null && (Link16Act == "Fishing" ||			                                                                 																Link16Act == "Reconnaissance" ||			         
			         												 Link16Act == "Noncombatant Operations"))
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Nonmil";
				Others = false;
			}				
			else if (Link16ID == "Hostile" && Link16Plat == "Surfaced Submarine" && Link16Act != null)
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Surfaced Submarine";
				Others = false;
			}	
			else if (Link16ID == "Hostile" && Link16Plat == "Intelligence Collector" && Link16Act != null)
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "SIGINT";
				Others = false;
			}			
			else if (Link16ID == "Hostile" && Link16Plat != null && (Link16Act == "Electronic Warfare (EW)" ||		
			                                                         Link16Act == "Intelligence Collecting" ||	
			                                                         Link16Act == "Electronic Warfare Support (ES)" ||	
			         												 Link16Act == "Electronic Attack (EA)"))
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "SIGINT";
				Others = false;
			}	
			else if (Link16ID == "Hostile" && (Link16Plat != "Aircraft Carrier" ||
				                               Link16Plat != "Cruiser" ||
				                               Link16Plat != "Battleship" ||
				                               Link16Plat != "Destroyer" ||
				                               Link16Plat != "Frigate" ||
				                               Link16Plat != "Fast Patrol Boat" ||
				                               Link16Plat != "Amphibious" ||
				                               Link16Plat != "LHA/LHD" ||
				                               Link16Plat != "Amphibious Assault Command Ship (LCC)" ||
				                               Link16Plat != "Landing Craft (LC)" ||
				                               Link16Plat != "Landing Platform" ||
				                               Link16Plat != "Landing Ship" ||
				                               Link16Plat != "Amphibious General Assault" ||
				                               Link16Plat != "Non-Military" ||
				                               Link16Plat != "Hospital Ship" ||
				                               Link16Plat != "Survey Vessel" ||
				                               Link16Plat != "Ocean Research" ||
				                               Link16Plat != "Fishing Vessel" ||
				                               Link16Plat != "Merchant Vessel" ||
				                               Link16Plat != "Intelligence Collector" ||
				                               Link16Plat != "Surfaced Submarine") && Link16Act != null)  
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "N.S.";			
				Others = false;
			}	

			//*****************************ID NEUTRAL****************************//
			
			else if (Link16ID == "Neutral" && Link16Plat != null && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "General";
				Link11IDAmp = "Neutral";
				Others = false;
			}
			
			//******************************ID FRIEND****************************//
			
			else if (Link16ID == "Friend" && Link16Plat == "Non-Military" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "General";
				Link11IDAmp = "Nonmil";
				Others = false;
			}
			else if (Link16ID == "Friend" && (Link16Plat == "Survey Vessel" ||
			                                  Link16Plat == "Fishing Vessel" ||
			                                  Link16Plat == "Merchant Vessel")  && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "General";
				Link11IDAmp = "Nonmil";
				Others = false;
			}
			else if (Link16ID == "Friend" && Link16Plat != null && (Link16Act == "Fishing" ||	
			         												Link16Act == "Noncombatant Operations"))
			{				
				Link11ID = "Friend";
				Link11PriAmp = "General";
				Link11IDAmp = "Nonmil";
				Others = false;
			}
			else if (Link16ID == "Friend" && (Link16Plat == "Auxiliary Ship" ||
			                                  Link16Plat == "Support")  && Link16Act != "Amphibious Warfare")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Auxiliary";
				Link11IDAmp = "N.S.";
				Others = false;
			}
			else if (Link16ID == "Friend" && Link16Plat == "Tanker/Oiler" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Auxiliary";
				Link11IDAmp = "Tanker";
				Others = false;
			}
			else if (Link16ID == "Friend" && Link16Plat == "Troop Ship" && Link16Act != "Amphibious Warfare")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Auxiliary";
				Link11IDAmp = "Troop";
				Others = false;
			}
			else if (Link16ID == "Friend" && Link16Plat == "Hospital Ship" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Auxiliary";
				Link11IDAmp = "Hosp";
				Others = false;
			}			
			else if (Link16ID == "Friend" && Link16Plat == "Missile Control Unit" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "N.S.";
				Others = false;
			}		
			else if (Link16ID == "Friend" && Link16Plat == "Fast Patrol Boat" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "PB/PG";
				Others = false;
			}		
			else if (Link16ID == "Friend" && Link16Plat == "Mine Warfare Ship" && (Link16Act == "Minelaying" ||
			                                                                       Link16Act == "Mine Warfare"))
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "Minelayer";
				Others = false;
			}
			else if (Link16ID == "Friend" && Link16Plat == "Ocean Research" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "Ocean Research";
				Others = false;
			}		
			else if (Link16ID == "Friend" && Link16Plat == "Intelligence Collector" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "SIGINT";
				Others = false;
			}		
			else if (Link16ID == "Friend" && Link16Plat != null && (Link16Act == "Electronic Warfare (EW)" ||		
			                                                        Link16Act == "Intelligence Collecting" ||	
			                                                        Link16Act == "Electronic Warfare Support (ES)" ||	
			         												Link16Act == "Electronic Attack (EA)"))
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "SIGINT";
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Air Cushion Vehicle" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "ACV/Hydro";
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Hydrofoil" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "ACV/Hydro";
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Surfaced Submarine" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "Surfaced Submarine";
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Mine Warfare Ship" && Link16Act == "Mine Countermeasures")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "Minesweeper";
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Mine Countermeasures Maritime Vessel (MCMV)" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Special Mission";
				Link11IDAmp = "Minesweeper";
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Command" && Link16Act != "Amphibious Warfare")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Line";
				Link11IDAmp = "N.S.";
				Others = false;
			}	
			else if (Link16ID == "Friend" && Link16Plat == "Aircraft Carrier" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Line";
				Link11IDAmp = "Aircraft Carrier";
				Others = false;
			}
			else if (Link16ID == "Friend" && Link16Plat == "Cruiser" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Line";
				Link11IDAmp = "CB";
				Others = false;
			}
			else if (Link16ID == "Friend" && Link16Plat == "Battleship" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Line";
				Link11IDAmp = "BB";
				Others = false;
			}
			else if (Link16ID == "Friend" && Link16Plat == "Destroyer" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Line";
				Link11IDAmp = "DD";
				Others = false;
			}
			else if (Link16ID == "Friend" && Link16Plat == "Frigate" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Line";
				Link11IDAmp = "FF";
				Others = false;
			}		
			else if (Link16ID == "Friend" && (Link16Plat == "Patrol" || Link16Plat == "Patrol Craft Escort") && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Line";
				Link11IDAmp = "Patrol Craft";
				Others = false;
			}				
			else if (Link16ID == "Friend" && (Link16Plat == "Amphibious" || Link16Plat == "Amphibious General Assualt") && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Amphibious";
				Link11IDAmp = "N.S.";
				Others = false;
			}				
			else if (Link16ID == "Friend" && Link16Plat == "Landing Platform" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Amphibious";
				Link11IDAmp = "Landing Platform";
				Others = false;
			}			
			else if (Link16ID == "Friend" && Link16Plat == "Landing Craft (LC)" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Amphibious";
				Link11IDAmp = "Landing Craft";
				Others = false;
			}				
			else if (Link16ID == "Friend" && Link16Plat == "Troop Ship" && Link16Act == "Amphibious Warfare")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Amphibious";
				Link11IDAmp = "Troop";
				Others = false;
			}				
			else if (Link16ID == "Friend" && Link16Plat == "Auxiliary Ship Support" && Link16Act == "Amphibious Warfare")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Amphibious";
				Link11IDAmp = "Cargo";
				Others = false;
			}					
			else if (Link16ID == "Friend" && Link16Plat == "Amphibious Assault Command Ship (LCC)" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Amphibious";
				Link11IDAmp = "Command";
				Others = false;
			}					
			else if (Link16ID == "Friend" && Link16Plat == "Command" && Link16Act == "Amphibious Warfare")
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Amphibious";
				Link11IDAmp = "Command";
				Others = false;
			}							
			else if (Link16ID == "Friend" && Link16Plat == "LHA/LHD" && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "Amphibious";
				Link11IDAmp = "LHA/LHD";
				Others = false;
			}				
			else if (Link16ID == "Friend" && (Link16Plat != "Non-Military" ||
				                              Link16Plat != "Survey Vessel" ||
				                              Link16Plat != "Fishing Vessel" ||
				                              Link16Plat != "Merchant Vessel" ||
				                              Link16Plat != "Auxiliary Ship" ||
				                              Link16Plat != "Support" ||
				                              Link16Plat != "Tanker/Oiler" ||
				                              Link16Plat != "Troop Ship" ||
				                              Link16Plat != "Hospital Ship" ||
				                              Link16Plat != "Missile Control Unit" ||
				                              Link16Plat != "Fast Patrol Boat" ||
				                              Link16Plat != "Mine Warfare Ship" ||
				                              Link16Plat != "Ocean Research" ||
				                              Link16Plat != "Intelligence Collector" ||
				                              Link16Plat != "Air Cushion Vehicle" ||
				                              Link16Plat != "Hydrofoil" ||
				                              Link16Plat != "Surfaced Submarine" ||
				                              Link16Plat != "Mine Warfare Ship" ||
				                              Link16Plat != "Mine Countermeasures Maritime Vessel (MCMV)" ||
				                              Link16Plat != "Command" ||
				                              Link16Plat != "Aircraft Carrier" ||
				                              Link16Plat != "Cruiser" ||
				                              Link16Plat != "Battleship" ||
				                              Link16Plat != "Destroyer" ||
				                              Link16Plat != "Frigate" ||
				                              Link16Plat != "Patrol" ||
				                              Link16Plat != "Patrol Craft Escort" ||
				                              Link16Plat != "Amphibious" ||
				                              Link16Plat != "Amphibious General Assault" ||
				                              Link16Plat != "Landing Platform" ||
				                              Link16Plat != "Landing Ship" ||
				                              Link16Plat != "Landing Craft (LC)" ||
				                              Link16Plat != "Troop Ship" ||
				                              Link16Plat != "Auxiliary Ship" ||
				                              Link16Plat != "Support" ||
				                              Link16Plat != "Amphibious Assault Command Ship (LCC)" ||
				                              Link16Plat != "LHA/LHD") && Link16Act != null)  
			{				
				Link11ID = "Friend";
				Link11PriAmp = "General";
				Link11IDAmp = "N.S.";		
				Others = false;
			}			
			else if (Others == true)
			{
				Link11ID = "Friend";
				Link11PriAmp = "General";
				Link11IDAmp = "N.S.";	
			}
			else
			{
				Link11ID = "Invalid";
				Link11PriAmp = "Invalid";
				Link11IDAmp = "Invalid";
			}
	
			L11ID = Link11ID;
			L11PriAmp = Link11PriAmp;
			L11IDAmp = Link11IDAmp;
		}	
		
		//************************************************************************************//
		//***********************Link 16 to Link 11 Subsurface Conversion*********************//
		//************************************************************************************//		
		
		public void Convert_SubsurfaceL16_L11(string Link16ID, string Link16Act, out string L11ID, out string L11Mission)
		{
			string Link11ID;
			string Link11Mission;
			
			//*****************************ID PENDING****************************//
			
			if (Link16ID == "Pending" && Link16Act == "Antisurface Warfare")
			{				
				Link11ID = "Pending";
				Link11Mission = "ANTISHIPPING";
			}
			else if (Link16ID == "Pending" && Link16Act == "Antisubmarine Warfare (ASW)")
			{				
				Link11ID = "Pending";
				Link11Mission = "ANTISUBMARINE";
			}	
			else if (Link16ID == "Pending" && Link16Act == "Reconnaissance")
			{				
				Link11ID = "Pending";
				Link11Mission = "RECONNAISSANCE";
			}			
			else if (Link16ID == "Pending" && Link16Act == "Minelaying")
			{				
				Link11ID = "Pending";
				Link11Mission = "MINELAYING";
			}			
			else if (Link16ID == "Pending" && Link16Act == "Transiting")
			{				
				Link11ID = "Pending";
				Link11Mission = "TRANSITING";
			}			
			else if (Link16ID == "Pending" && (Link16Act == "Search And Rescue (SAR)" ||
			                                   Link16Act == "Special Warfare" ||
			                                   Link16Act == "Clandestine Operations" ||
			                                   Link16Act == "Special Operations" ||
			                                   Link16Act == "Combat Search And Rescue (CSAR)"))
			{				
				Link11ID = "Pending";
				Link11Mission = "SPECIAL/SAR";
			}		
			else if (Link16ID == "Pending" && (Link16Act == "Escorting" ||
			                                   Link16Act == "Direct Support"))
			{				
				Link11ID = "Pending";
				Link11Mission = "ESCORT";
			}				
			else if (Link16ID == "Pending" && (Link16Act != "Search And Rescue (SAR)" ||
			                                   Link16Act != "Special Warfare" ||
			                                   Link16Act != "Clandestine Operations" ||
			                                   Link16Act != "Special Operations" ||
			                                   Link16Act != "Combat Search And Rescue (CSAR)"||
			                                   Link16Act != "Antisurface Warfare"||
			                                   Link16Act != "Antisubmarine Warfare (ASW)"||
			                                   Link16Act != "Reconnaissance"||
			                                   Link16Act != "Minelaying"||
			                                   Link16Act != "Transiting" ||
			                                   Link16Act != "Escroting"||
			                                   Link16Act != "Direct Support"))
			{				
				Link11ID = "Pending";
				Link11Mission = "N.S.";
			}				
			
			//*****************************ID UNKNOWN****************************//
			
			else if (Link16ID == "Unknown" && Link16Act == "Antisurface Warfare")
			{				
				Link11ID = "Unknown";
				Link11Mission = "ANTISHIPPING";
			}
			else if (Link16ID == "Unknown" && Link16Act == "Antisubmarine Warfare (ASW)")
			{				
				Link11ID = "Unknown";
				Link11Mission = "ANTISUBMARINE";
			}	
			else if (Link16ID == "Unknown" && Link16Act == "Reconnaissance")
			{				
				Link11ID = "Unknown";
				Link11Mission = "RECONNAISSANCE";
			}			
			else if (Link16ID == "Unknown" && Link16Act == "Minelaying")
			{				
				Link11ID = "Unknown";
				Link11Mission = "MINELAYING";
			}			
			else if (Link16ID == "Unknown" && Link16Act == "Transiting")
			{				
				Link11ID = "Unknown";
				Link11Mission = "TRANSITING";
			}			
			else if (Link16ID == "Unknown" && (Link16Act == "Search And Rescue (SAR)" ||
			                                   Link16Act == "Special Warfare" ||
			                                   Link16Act == "Clandestine Operations" ||
			                                   Link16Act == "Special Operations" ||
			                                   Link16Act == "Combat Search And Rescue (CSAR)"))
			{				
				Link11ID = "Unknown";
				Link11Mission = "SPECIAL/SAR";
			}	
			else if (Link16ID == "Unknown" && (Link16Act == "Escorting" ||
			                                   Link16Act == "Direct Support"))
			{				
				Link11ID = "Unknown";
				Link11Mission = "ESCORT";
			}	
			else if (Link16ID == "Unknown" && (Link16Act != "Search And Rescue (SAR)" ||
			                                   Link16Act != "Special Warfare" ||
			                                   Link16Act != "Clandestine Operations" ||
			                                   Link16Act != "Special Operations" ||
			                                   Link16Act != "Combat Search And Rescue (CSAR)"||
			                                   Link16Act != "Antisurface Warfare"||
			                                   Link16Act != "Antisubmarine Warfare (ASW)"||
			                                   Link16Act != "Reconnaissance"||
			                                   Link16Act != "Minelaying"||
			                                   Link16Act != "Transiting" ||
			                                   Link16Act != "Escroting" ||
			                                   Link16Act != "Direct Support"))
			{				
				Link11ID = "Unknown";
				Link11Mission = "N.S.";
			}				
			
			//*****************************ID SUSPECT****************************//

			else if (Link16ID == "Suspect" && Link16Act == "Antisurface Warfare")
			{				
				Link11ID = "Unknown";
				Link11Mission = "ANTISHIPPING";
			}
			else if (Link16ID == "Suspect" && Link16Act == "Antisubmarine Warfare (ASW)")
			{				
				Link11ID = "Unknown";
				Link11Mission = "ANTISUBMARINE";
			}	
			else if (Link16ID == "Suspect" && Link16Act == "Reconnaissance")
			{				
				Link11ID = "Unknown";
				Link11Mission = "RECONNAISSANCE";
			}			
			else if (Link16ID == "Suspect" && Link16Act == "Minelaying")
			{				
				Link11ID = "Unknown";
				Link11Mission = "MINELAYING";
			}			
			else if (Link16ID == "Suspect" && Link16Act == "Transiting")
			{				
				Link11ID = "Unknown";
				Link11Mission = "TRANSITING";
			}			
			else if (Link16ID == "Suspect" && (Link16Act == "Search And Rescue (SAR)" ||
			                                   Link16Act == "Special Warfare" ||
			                                   Link16Act == "Clandestine Operations" ||
			                                   Link16Act == "Special Operations" ||
			                                   Link16Act == "Combat Search And Rescue (CSAR)"))
			{				
				Link11ID = "Unknown";
				Link11Mission = "SPECIAL/SAR";
			}	
			else if (Link16ID == "Suspect" && (Link16Act == "Escorting" ||
			                                   Link16Act == "Direct Support"))
			{				
				Link11ID = "Unknown";
				Link11Mission = "ESCORT";
			}				
			else if (Link16ID == "Suspect" && (Link16Act != "Search And Rescue (SAR)" ||
			                                   Link16Act != "Special Warfare" ||
			                                   Link16Act != "Clandestine Operations" ||
			                                   Link16Act != "Special Operations" ||
			                                   Link16Act != "Combat Search And Rescue (CSAR)"||
			                                   Link16Act != "Antisurface Warfare"||
			                                   Link16Act != "Antisubmarine Warfare (ASW)"||
			                                   Link16Act != "Reconnaissance"||
			                                   Link16Act != "Minelaying"||
			                                   Link16Act != "Transiting" ||
			                                   Link16Act != "Escroting" ||
			                                   Link16Act != "Direct Support"))
			{				
				Link11ID = "Unknown";
				Link11Mission = "N.S.";
			}				
			
			//**************************ID ASSUMED FRIEND**************************//

			else if (Link16ID == "Assumed Friend" && Link16Act == "Antisurface Warfare")
			{				
				Link11ID = "Unknown";
				Link11Mission = "ANTISHIPPING";
			}
			else if (Link16ID == "Assumed Friend" && Link16Act == "Antisubmarine Warfare (ASW)")
			{				
				Link11ID = "Unknown";
				Link11Mission = "ANTISUBMARINE";
			}	
			else if (Link16ID == "Assumed Friend" && Link16Act == "Reconnaissance")
			{				
				Link11ID = "Unknown";
				Link11Mission = "RECONNAISSANCE";
			}			
			else if (Link16ID == "Assumed Friend" && Link16Act == "Minelaying")
			{				
				Link11ID = "Unknown";
				Link11Mission = "MINELAYING";
			}			
			else if (Link16ID == "Assumed Friend" && Link16Act == "Transiting")
			{				
				Link11ID = "Unknown";
				Link11Mission = "TRANSITING";
			}			
			else if (Link16ID == "Assumed Friend" && (Link16Act == "Search And Rescue (SAR)" ||
			                                   		  Link16Act == "Special Warfare" ||
			                                   		  Link16Act == "Clandestine Operations" ||
			                                  		  Link16Act == "Special Operations" ||
			                                 		  Link16Act == "Combat Search And Rescue (CSAR)"))
			{				
				Link11ID = "Unknown";
				Link11Mission = "SPECIAL/SAR";
			}	
			else if (Link16ID == "Assumed Friend" && (Link16Act == "Escorting" ||
			                                  		  Link16Act == "Direct Support"))
			{				
				Link11ID = "Unknown";
				Link11Mission = "ESCORT";
			}				
			else if (Link16ID == "Assumed Friend" && (Link16Act != "Search And Rescue (SAR)" ||
			                                   		  Link16Act != "Special Warfare" ||
			                                   		  Link16Act != "Clandestine Operations" ||
			                                   		  Link16Act != "Special Operations" ||
			                                   		  Link16Act != "Combat Search And Rescue (CSAR)"||
			                                  		  Link16Act != "Antisurface Warfare"||
			                                   		  Link16Act != "Antisubmarine Warfare (ASW)"||
			                                  		  Link16Act != "Reconnaissance"||
			                                   		  Link16Act != "Minelaying"||
			                                   		  Link16Act != "Transiting" ||
			                                   		  Link16Act != "Escroting" ||
			                                  		  Link16Act != "Direct Support"))
			{				
				Link11ID = "Unknown";
				Link11Mission = "N.S.";
			}				
		
			//*****************************ID HOSTILE*****************************//

			else if (Link16ID == "Hostile" && Link16Act == "Antisurface Warfare")
			{				
				Link11ID = "Hostile";
				Link11Mission = "ANTISHIPPING";
			}
			else if (Link16ID == "Hostile" && Link16Act == "Antisubmarine Warfare (ASW)")
			{				
				Link11ID = "Hostile";
				Link11Mission = "ANTISUBMARINE";
			}	
			else if (Link16ID == "Hostile" && Link16Act == "Reconnaissance")
			{				
				Link11ID = "Hostile";
				Link11Mission = "RECONNAISSANCE";
			}			
			else if (Link16ID == "Hostile" && Link16Act == "Minelaying")
			{				
				Link11ID = "Hostile";
				Link11Mission = "MINELAYING";
			}			
			else if (Link16ID == "Hostile" && Link16Act == "Transiting")
			{				
				Link11ID = "Hostile";
				Link11Mission = "TRANSITING";
			}			
			else if (Link16ID == "Hostile" && (Link16Act == "Search And Rescue (SAR)" ||
			                                   Link16Act == "Special Warfare" ||
			                                   Link16Act == "Clandestine Operations" ||
			                                   Link16Act == "Special Operations" ||
			                                   Link16Act == "Combat Search And Rescue (CSAR)"))
			{				
				Link11ID = "Hostile";
				Link11Mission = "SPECIAL/SAR";
			}	
			else if (Link16ID == "Hostile" && (Link16Act == "Escorting" ||
			                                   Link16Act == "Direct Support"))
			{				
				Link11ID = "Hostile";
				Link11Mission = "ESCORT";
			}				
			else if (Link16ID == "Hostile" && (Link16Act != "Search And Rescue (SAR)" ||
			                                   Link16Act != "Special Warfare" ||
			                                   Link16Act != "Clandestine Operations" ||
			                                   Link16Act != "Special Operations" ||
			                                   Link16Act != "Combat Search And Rescue (CSAR)"||
			                                   Link16Act != "Antisurface Warfare"||
			                                   Link16Act != "Antisubmarine Warfare (ASW)"||
			                                   Link16Act != "Reconnaissance"||
			                                   Link16Act != "Minelaying"||
			                                   Link16Act != "Transiting" ||
			                                   Link16Act != "Escroting"||
			                                   Link16Act != "Direct Support"))
			{				
				Link11ID = "Hostile";
				Link11Mission = "N.S.";
			}				
			
			//*****************************ID NEUTRAL****************************//
			
			else if (Link16ID == "Neutral" && Link16Act == "Antisurface Warfare")
			{				
				Link11ID = "Friend";
				Link11Mission = "ANTISHIPPING";
			}
			else if (Link16ID == "Neutral" && Link16Act == "Antisubmarine Warfare (ASW)")
			{				
				Link11ID = "Friend";
				Link11Mission = "ANTISUBMARINE";
			}	
			else if (Link16ID == "Neutral" && Link16Act == "Reconnaissance")
			{				
				Link11ID = "Friend";
				Link11Mission = "RECONNAISSANCE";
			}			
			else if (Link16ID == "Neutral" && Link16Act == "Minelaying")
			{				
				Link11ID = "Friend";
				Link11Mission = "MINE LAYING";
			}			
			else if (Link16ID == "Neutral" && Link16Act == "Transiting")
			{				
				Link11ID = "Friend";
				Link11Mission = "TRANSITING";
			}			
			else if (Link16ID == "Neutral" && (Link16Act == "Search And Rescue (SAR)" ||
			                                   Link16Act == "Special Warfare" ||
			                                   Link16Act == "Clandestine Operations" ||
			                                   Link16Act == "Special Operations" ||
			                                   Link16Act == "Combat Search And Rescue (CSAR)"))
			{				
				Link11ID = "Friend";
				Link11Mission = "SPECIAL/SAR";
			}
			else if (Link16ID == "Neutral" && (Link16Act == "Escorting" ||
			                                   Link16Act == "Direct Support"))
			{				
				Link11ID = "Friend";
				Link11Mission = "ESCORT";
			}				
			else if (Link16ID == "Neutral" && (Link16Act != "Search And Rescue (SAR)" ||
			                                   Link16Act != "Special Warfare" ||
			                                   Link16Act != "Clandestine Operations" ||
			                                   Link16Act != "Special Operations" ||
			                                   Link16Act != "Combat Search And Rescue (CSAR)"||
			                                   Link16Act != "Antisurface Warfare"||
			                                   Link16Act != "Antisubmarine Warfare (ASW)"||
			                                   Link16Act != "Reconnaissance"||
			                                   Link16Act != "Minelaying"||
			                                   Link16Act != "Transiting" ||
			                                   Link16Act != "Escroting"||
			                                   Link16Act != "Direct Support"))
			{				
				Link11ID = "Friend";
				Link11Mission = "N.S.";
			}				

			//*****************************ID FRIEND*****************************//

			else if (Link16ID == "Friend" && Link16Act == "Antisurface Warfare")
			{				
				Link11ID = "Friend";
				Link11Mission = "ANTISHIPPING";
			}
			else if (Link16ID == "Friend" && Link16Act == "Antisubmarine Warfare (ASW)")
			{				
				Link11ID = "Friend";
				Link11Mission = "ANTISUBMARINE";
			}	
			else if (Link16ID == "Friend" && Link16Act == "Reconnaissance")
			{				
				Link11ID = "Friend";
				Link11Mission = "RECONNAISSANCE";
			}			
			else if (Link16ID == "Friend" && Link16Act == "Minelaying")
			{				
				Link11ID = "Friend";
				Link11Mission = "MINELAYING";
			}			
			else if (Link16ID == "Friend" && Link16Act == "Transiting")
			{				
				Link11ID = "Friend";
				Link11Mission = "TRANSITING";
			}			
			else if (Link16ID == "Friend" && (Link16Act == "Search And Rescue (SAR)" ||
			                                  Link16Act == "Special Warfare" ||
			                                  Link16Act == "Clandestine Operations" ||
			                                  Link16Act == "Special Operations" ||
			                                  Link16Act == "Combat Search And Rescue (CSAR)"))
			{				
				Link11ID = "Friend";
				Link11Mission = "SPECIAL/SAR";
			}
			else if (Link16ID == "Friend" && (Link16Act == "Escorting" ||
			                                  Link16Act == "Direct Support"))
			{				
				Link11ID = "Friend";
				Link11Mission = "ESCORT";
			}				
			else if (Link16ID == "Friend" && (Link16Act != "Search And Rescue (SAR)" ||
			                                  Link16Act != "Special Warfare" ||
			                                  Link16Act != "Clandestine Operations" ||
			                                  Link16Act != "Special Operations" ||
			                                  Link16Act != "Combat Search And Rescue (CSAR)"||
			                                  Link16Act != "Antisurface Warfare"||
			                                  Link16Act != "Antisubmarine Warfare (ASW)"||
			                                  Link16Act != "Reconnaissance"||
			                                  Link16Act != "Minelaying"||
			                                  Link16Act != "Transiting" ||
			                                  Link16Act != "Escroting"||
			                                  Link16Act != "Direct Support"))
			{				
				Link11ID = "Friend";
				Link11Mission = "N.S.";
			}				
			else
			{
				Link11ID = "Invalid";
				Link11Mission = "Invalid";
			}
	
			L11ID = Link11ID;
			L11Mission = Link11Mission;
		}			

		//************************************************************************************//
		//*************************Link 16 to Link 11 Land Conversion************************//
		//************************************************************************************//		
		
		public void Convert_LandL16_L11(string Link16ID, string Link16Plat, out string L11Point, out string L11PointAmp)
		{			
			string Link11Point;
			string Link11PointAmp;
			
			//*****************************ID PENDING****************************//
			
			if (Link16ID == "Pending" && Link16Plat == "Radar Site")
			{				
				Link11Point = "RADAR";
				Link11PointAmp = "N.S.";
			}
			else if (Link16ID == "Pending" && Link16Plat != "Radar Site")
			{				
				Link11Point = "REFERENCE POINT (GENERAL)";
				Link11PointAmp = "N.S.";
			}
						
			//*****************************ID UNKNOWN****************************//
			
			else if (Link16ID == "Unknown" && Link16Plat == "Radar Site")
			{				
				Link11Point = "RADAR";
				Link11PointAmp = "N.S.";
			}
			else if (Link16ID == "Unknown" && Link16Plat != "Radar Site")
			{				
				Link11Point = "REFERENCE POINT (GENERAL)";
				Link11PointAmp = "N.S.";
			}
			
			//*****************************ID SUSPECT****************************//

			else if (Link16ID == "Suspect" && Link16Plat == "Troop Concentration/Unit")
			{				
				Link11Point = "ENEMY POINT";
				Link11PointAmp = "Troop Concentration";
			}
			else if (Link16ID == "Suspect" && Link16Plat == "Airfield/Airbase")
			{				
				Link11Point = "ENEMY POINT";
				Link11PointAmp = "Air Base";
			}
			else if (Link16ID == "Suspect" && Link16Plat == "Surface-to-Air Missile (SAM) Site")
			{				
				Link11Point = "ENEMY POINT";
				Link11PointAmp = "SAM Site";
			}		
			else if (Link16ID == "Suspect" && Link16Plat == "Field Artillery")
			{				
				Link11Point = "ENEMY POINT";
				Link11PointAmp = "Artillery";
			}		
			else if (Link16ID == "Suspect" && Link16Plat == "Convoy")
			{				
				Link11Point = "ENEMY POINT";
				Link11PointAmp = "Convoy";
			}	
			else if (Link16ID == "Suspect" && Link16Plat == "Train")
			{				
				Link11Point = "ENEMY POINT";
				Link11PointAmp = "Rail";
			}		
			else if (Link16ID == "Suspect" && Link16Plat == "Bridge")
			{				
				Link11Point = "ENEMY POINT";
				Link11PointAmp = "Bridge";
			}				
			else if (Link16ID == "Suspect" && (Link16Plat != "Troop Concentration/Unit"||
			                                   Link16Plat != "Airfield/Airbase"||
			                                   Link16Plat != "Surface-to-Air Missile (SAM) Site"||
			                                   Link16Plat != "Field Artillery"||
			                                   Link16Plat != "Convoy"||
			                                   Link16Plat != "Train"||
			                                   Link16Plat != "Bridge"))
			{				
				Link11Point = "ENEMY POINT";
				Link11PointAmp = "N.S.";
			}			
			
			//**************************ID ASSUMED FRIEND**************************//

			else if (Link16ID == "Assumed Friend" && Link16Plat == "Radar Site")
			{				
				Link11Point = "RADAR";
				Link11PointAmp = "N.S.";
			}
			else if (Link16ID == "Assumed Friend" && Link16Plat != "Radar Site")
			{				
				Link11Point = "REFERENCE POINT (GENERAL)";
				Link11PointAmp = "N.S.";
			}
		
			//*****************************ID HOSTILE*****************************//

			else if (Link16ID == "Hostile" && Link16Plat == "Trrop Concentration/Unit")
			{				
				Link11Point = "ENEMY POINT";
				Link11PointAmp = "Troop Concentration";
			}
			else if (Link16ID == "Hostile" && Link16Plat == "Airfield/Airbase")
			{				
				Link11Point = "ENEMY POINT";
				Link11PointAmp = "Air Base";
			}
			else if (Link16ID == "Hostile" && Link16Plat == "Surface-to-Air Missile (SAM) Site")
			{				
				Link11Point = "ENEMY POINT";
				Link11PointAmp = "SAM Site";
			}		
			else if (Link16ID == "Hostile" && Link16Plat == "Field Artillery")
			{				
				Link11Point = "ENEMY POINT";
				Link11PointAmp = "Artillery";
			}		
			else if (Link16ID == "Hostile" && Link16Plat == "Convoy")
			{				
				Link11Point = "ENEMY POINT";
				Link11PointAmp = "Convoy";
			}	
			else if (Link16ID == "Hostile" && Link16Plat == "Train")
			{				
				Link11Point = "ENEMY POINT";
				Link11PointAmp = "Rail";
			}		
			else if (Link16ID == "Hostile" && Link16Plat == "Bridge")
			{				
				Link11Point = "ENEMY POINT";
				Link11PointAmp = "Bridge";
			}	
			else if (Link16ID == "Hostile" && (Link16Plat != "Troop Concentration/Unit"||
			                                   Link16Plat != "Airfield/Airbase"||
			                                   Link16Plat != "Surface-to-Air Missile (SAM) Site"||
			                                   Link16Plat != "Field Artillery"||
			                                   Link16Plat != "Convoy"||
			                                   Link16Plat != "Train"||
			                                   Link16Plat != "Bridge"))
			{				
				Link11Point = "ENEMY POINT";
				Link11PointAmp = "N.S.";
			}					
			
			//*****************************ID NEUTRAL****************************//
			
			else if (Link16ID == "Neutral" && Link16Plat == "Radar Site")
			{				
				Link11Point = "RADAR";
				Link11PointAmp = "N.S.";
			}
			else if (Link16ID == "Neutral" && Link16Plat != "Radar Site")
			{				
				Link11Point = "REFERENCE POINT (GENERAL)";
				Link11PointAmp = "N.S.";
			}

			//*****************************ID FRIEND*****************************//

			else if (Link16ID == "Friend" && Link16Plat == "Radar Site")                                                            
			{				
				Link11Point = "RADAR";
				Link11PointAmp = "N.S.";

			}		
			else if (Link16ID == "Friend" && Link16Plat == "Maritime Headquarters")                                                            
			{				
				Link11Point = "SUPPORT UNIT (SU)";
				Link11PointAmp = "MHQ";

			}	
			else if (Link16ID == "Friend" && Link16Plat == "Airfield/Airbase")                                                            
			{				
				Link11Point = "SUPPORT UNIT (SU)";
				Link11PointAmp = "Air Base";

			}			
			else if (Link16ID == "Friend" && Link16Plat == "Surface-to-Air Missile (SAM) Site")                                                            
			{				
				Link11Point = "SUPPORT UNIT (SU)";
				Link11PointAmp = "SAM Site";

			}	
			else if (Link16ID == "Friend" && Link16Plat == "Terminal High Altitude Area Defense (THAAD)")                                                            
			{				
				Link11Point = "SUPPORT UNIT (SU)";
				Link11PointAmp = "SAM Site";

			}	
			else if (Link16ID == "Friend" && Link16Plat == "Ballistic Missile Defense Site")                                                            
			{				
				Link11Point = "SUPPORT UNIT (SU)";
				Link11PointAmp = "SAM Site";

			}	
			else if (Link16ID == "Friend" && Link16Plat == "Air Support Radar Team (ASRT)")                                                            
			{				
				Link11Point = "SUPPORT UNIT (SU)";
				Link11PointAmp = "ASRT";

			}		
			else if (Link16ID == "Friend" && Link16Plat == "Direct Air Support Center (DASC)")                                                            
			{				
				Link11Point = "SUPPORT UNIT (SU)";
				Link11PointAmp = "DASC";

			}	
			else if (Link16ID == "Friend" && Link16Plat == "Forward Air Control Party (FACP)/Tactical Air Control Party(TACP)")                                                            
			{				
				Link11Point = "SUPPORT UNIT (SU)";
				Link11PointAmp = "FACP";

			}	
			else if (Link16ID == "Friend" && Link16Plat == "Air Defense Artillery")                                                            
			{				
				Link11Point = "SUPPORT UNIT (SU)";
				Link11PointAmp = "ADA/BOC/TDS";

			}		
			else if (Link16ID == "Friend" && Link16Plat == "Tactical Operations Center (TOC)")                                                            
			{				
				Link11Point = "SUPPORT UNIT (SU)";
				Link11PointAmp = "ADA/BOC/TDS";

			}		
			else if (Link16ID == "Friend" && Link16Plat == "Tactical Data System (TDS)")                                                            
			{				
				Link11Point = "SUPPORT UNIT (SU)";
				Link11PointAmp = "ADA/BOC/TDS";

			}			
			else if (Link16ID == "Friend" && Link16Plat == "Joint Tactical Ground Station (JTAGS)")                                                            
			{				
				Link11Point = "SUPPORT UNIT (SU)";
				Link11PointAmp = "ADA/BOC/TDS";

			}			
			else if (Link16ID == "Friend" && (Link16Plat != "Radar Site"||
			                                  Link16Plat != "Maritime Headquarters"||
			                                  Link16Plat != "Airfield/Airbase"||
			                                  Link16Plat != "Surface-to-Air Missile (SAM) Site"||
			                                  Link16Plat != "Terminal High Altitude Area Defense (THAAD)"||
			                                  Link16Plat != "Ballistic Missile Defense Site"||
			                                  Link16Plat != "Air Support Radar Team (ASRT)"||
			                                  Link16Plat != "Direct Air Support Center (DASC)"||
			                                  Link16Plat != "Forward Air Control Party (FACP)/Tactical Air Control Party(TACP)"||
			                                  Link16Plat != "Air Defense Artillery"||
			                                  Link16Plat != "Tactical Operations Center (TOC)"||
			                                  Link16Plat != "Tactical Data System (TDS)"||
			                                  Link16Plat != "Joint Tactical Ground Station (JTAGS)"))
			{				
				Link11Point = "REFERENCE POINT (GENERAL)";
				Link11PointAmp = "N.S.";
			}				
			else
			{
				Link11Point = "Invalid";
				Link11PointAmp = "Invalid";
			}
	
			L11Point = Link11Point;
			L11PointAmp = Link11PointAmp;
		}			

		//************************************************************************************//
		//*************************Link 16 to Link 11 Space Conversion************************//
		//************************************************************************************//		
		
		public void Convert_SpaceL16_L11(string Link16ID, string Link16Plat, string Link16Act, out string L11ID, out string L11PriAmp, out string L11IDAmp)
		{
			string Link11ID;
			string Link11PriAmp;
			string Link11IDAmp;
			bool Others = true;
			
			//*****************************ID PENDING****************************//
			
			if (Link16ID == "Pending" && Link16Plat != null && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Pending";
				Link11IDAmp = "N.S.";
				Others = false;
			}
			
			//*****************************ID UNKNOWN****************************//
			
			else if (Link16ID == "Unknown" && Link16Plat != null && Link16Act != null)
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Unknown";
				Link11IDAmp = "N.S.";
				Others = false;
			}
			
			//*****************************ID SUSPECT****************************//

			else if (Link16ID == "Suspect" && Link16Plat != null && Link16Act != null)
			{					
				Link11ID = "Unknown";
				Link11PriAmp = "Suspect";
				Link11IDAmp = "N.S.";	
				Others = false;
			}	
			
			//**************************ID ASSUMED FRIEND**************************//

			else if (Link16ID == "Assumed Friend" && Link16Plat != null && Link16Act != null)                                                            
			{				
				Link11ID = "Unknown";
				Link11PriAmp = "Assumed Friend";
				Link11IDAmp = "N.S.";			
				Others = false;
			}	
		
			//*****************************ID HOSTILE*****************************//

			else if (Link16ID == "Hostile" && Link16Plat != null && Link16Act != null)                                                            
			{				
				Link11ID = "Hostile";
				Link11PriAmp = "General";
				Link11IDAmp = "Missile";	
				Others = false;
			}	
			
			//*****************************ID NEUTRAL****************************//
			
			else if (Link16ID == "Neutral" && Link16Plat != null && Link16Act != null)
			{				
				Link11ID = "Friend";
				Link11PriAmp = "General";
				Link11IDAmp = "Neutral";
				Others = false;
			}

			//*****************************ID FRIEND*****************************//

			else if (Link16ID == "Friend" && Link16Plat != null && Link16Act != null)                                                            
			{				
				Link11ID = "Friend";
				Link11PriAmp = "General";
				Link11IDAmp = "Missile";	
				Others = false;
			}		
			else if (Others == true)
			{
				Link11ID = "Friend";
				Link11PriAmp = "General";
				Link11IDAmp = "N.S.";					
			}
			else
			{
				Link11ID = "Invalid";
				Link11PriAmp = "Invalid";
				Link11IDAmp = "Invalid";
			}
	
			L11ID = Link11ID;
			L11PriAmp = Link11PriAmp;
			L11IDAmp = Link11IDAmp;
		}	
		
		//************************************************************************************//
		//**************************Link 11 to Link 16 Air Conversion*************************//
		//************************************************************************************//		
		
		public void Convert_AirL11_L16(string Link11ID, string Link11PriAmp, string Link11IDAmp, out string L16ID, out string L16Plat, out string L16Act)
		{
			string Link16ID;
			string Link16Plat;
			string Link16Act;
			
			//*****************************ID PENDING****************************//
			
			if (Link11ID == "Unknown" && Link11PriAmp == "Pending" && Link11IDAmp == "N.S.")
			{				
				Link16ID = "Pending";
				Link16Plat = "N.S.";
				Link16Act = "N.S.";
			}
			
			//*****************************ID UNKNOWN****************************//
			
			else if (Link11ID == "Unknown" && Link11PriAmp == "Unknown" && Link11IDAmp == "Bomber")
			{				
				Link16ID = "Unknown";
				Link16Plat = "Bomber";
				Link16Act = "N.S.";
			}
			else if (Link11ID == "Unknown" && Link11PriAmp == "Unknown" && Link11IDAmp == "Fighter")
			{				
				Link16ID = "Unknown";
				Link16Plat = "Fighter";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Unknown" && Link11PriAmp == "Unknown" && Link11IDAmp == "AEW/RECCE/EW/Decoy")
			{				
				Link16ID = "Unknown";
				Link16Plat = "Airborne Early Warning and Control (AEW)";
				Link16Act = "N.S.";
			}		
			else if (Link11ID == "Unknown" && Link11PriAmp == "Unknown" && Link11IDAmp == "Helo/Transport")
			{				
				Link16ID = "Unknown";
				Link16Plat = "Helicopter (HELO)";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Unknown" && Link11PriAmp == "Unknown" && Link11IDAmp == "Missile Platform")
			{				
				Link16ID = "Unknown";
				Link16Plat = "Missile Control Unit";
				Link16Act = "N.S.";
			}					
			else if (Link11ID == "Unknown" && Link11PriAmp == "Unknown" && Link11IDAmp == "N.S.")
			{				
				Link16ID = "Unknown";
				Link16Plat = "N.S.";
				Link16Act = "N.S.";
			}	
			
			//*****************************ID SUSPECT****************************//

			else if (Link11ID == "Unknown" && Link11PriAmp == "Suspect" && Link11IDAmp == "Drone/RPV")
			{				
				Link16ID = "Suspect";
				Link16Plat = "Drone";
				Link16Act = "N.S.";
			}	
			else if (Link11ID == "Unknown" && Link11PriAmp == "Suspect" && Link11IDAmp == "Bomber")
			{				
				Link16ID = "Suspect";
				Link16Plat = "Bomber";
				Link16Act = "N.S.";
			}				
			else if (Link11ID == "Unknown" && Link11PriAmp == "Suspect" && Link11IDAmp == "Fighter")
			{				
				Link16ID = "Suspect";
				Link16Plat = "Fighter";
				Link16Act = "N.S.";
			}		
			else if (Link11ID == "Unknown" && Link11PriAmp == "Suspect" && Link11IDAmp == "AEW/RECCE/EW/Decoy")
			{				
				Link16ID = "Suspect";
				Link16Plat = "Airborne Early Warning and Control (AEW)";
				Link16Act = "N.S.";
			}					
			else if (Link11ID == "Unknown" && Link11PriAmp == "Suspect" && Link11IDAmp == "Helo/Transport")
			{				
				Link16ID = "Suspect";
				Link16Plat = "Helicopter (HELO)";
				Link16Act = "N.S.";
			}		
			else if (Link11ID == "Unknown" && Link11PriAmp == "Suspect" && Link11IDAmp == "Missile Platform")
			{				
				Link16ID = "Suspect";
				Link16Plat = "Missile Control Unit";
				Link16Act = "N.S.";
			}		
			else if (Link11ID == "Unknown" && Link11PriAmp == "Suspect" && Link11IDAmp == "Xray/Intruder")
			{				
				Link16ID = "Suspect";
				Link16Plat = "N.S.";
				Link16Act = "XRay";
			}					
			else if (Link11ID == "Unknown" && Link11PriAmp == "Suspect" && Link11IDAmp == "N.S.")
			{				
				Link16ID = "Suspect";
				Link16Plat = "N.S.";
				Link16Act = "N.S.";
			}				
			
			//**************************ID ASSUMED FRIEND**************************//

			else if (Link11ID == "Unknown" && Link11PriAmp == "Assumed Friend" && Link11IDAmp == "Bomber")
			{				
				Link16ID = "Assumed Friend";
				Link16Plat = "Bomber";
				Link16Act = "N.S.";
			}	
			else if (Link11ID == "Unknown" && Link11PriAmp == "Assumed Friend" && Link11IDAmp == "AEW/RECCE/EW/Decoy")
			{				
				Link16ID = "Assumed Friend";
				Link16Plat = "Airborne Early Warning and Control (AEW)";
				Link16Act = "N.S.";
			}				
			else if (Link11ID == "Unknown" && Link11PriAmp == "Assumed Friend" && Link11IDAmp == "Helo/Transport")
			{				
				Link16ID = "Assumed Friend";
				Link16Plat = "Helicopter (HELO)";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Unknown" && Link11PriAmp == "Assumed Friend" && Link11IDAmp == "Missile Platform")
			{				
				Link16ID = "Assumed Friend";
				Link16Plat = "Missile Control Unit";
				Link16Act = "N.S.";
			}				
			else if (Link11ID == "Unknown" && Link11PriAmp == "Assumed Friend" && Link11IDAmp == "N.S.")
			{				
				Link16ID = "Assumed Friend";
				Link16Plat = "N.S.";
				Link16Act = "N.S.";
			}				
			
			//*****************************ID HOSTILE*****************************//

			else if (Link11ID == "Hostile" && Link11PriAmp == "General" && Link11IDAmp == "Missile")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Missile";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Hostile" && Link11PriAmp == "General" && Link11IDAmp == "Bomber")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Bomber.";
				Link16Act = "N.S.";
			}				
			else if (Link11ID == "Hostile" && Link11PriAmp == "General" && Link11IDAmp == "Fighter")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Fighter";
				Link16Act = "N.S.";
			}					
			else if (Link11ID == "Hostile" && Link11PriAmp == "General" && Link11IDAmp == "AEW/RECCE/EW/Decoy")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Airborne Early Warning and Control (AEW)";
				Link16Act = "N.S.";
			}				
			else if (Link11ID == "Hostile" && Link11PriAmp == "General" && Link11IDAmp == "Helo/Transport")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Helicopter (HELO)";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Hostile" && Link11PriAmp == "General" && Link11IDAmp == "Missile Platform")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Missile Control Unit";
				Link16Act = "N.S.";
			}		
			else if (Link11ID == "Hostile" && Link11PriAmp == "General" && Link11IDAmp == "Jammer")
			{				
				Link16ID = "Hostile";
				Link16Plat = "N.S.";
				Link16Act = "Jammer";
			}				
			else if (Link11ID == "Hostile" && Link11PriAmp == "General" && Link11IDAmp == "N.S.")
			{				
				Link16ID = "Hostile";
				Link16Plat = "N.S.";
				Link16Act = "N.S.";
			}					
			
			//*****************************ID NEUTRAL****************************//
			
			else if (Link11ID == "Friend" && Link11PriAmp == "General" && Link11IDAmp == "Neutral")
			{				
				Link16ID = "Neutral";
				Link16Plat = "N.S.";
				Link16Act = "N.S.";
			}			
			
			//*****************************ID FRIEND*****************************//

			else if (Link11ID == "Friend" && Link11PriAmp == "General" && Link11IDAmp == "Non Mil")
			{				
				Link16ID = "Friend";
				Link16Plat = "Civil, Airliner";
				Link16Act = "N.S.";
			}				
			else if (Link11ID == "Friend" && Link11PriAmp == "General" && Link11IDAmp == "Missile")
			{				
				Link16ID = "Friend";
				Link16Plat = "Missile";
				Link16Act = "N.S.";
			}		
			else if (Link11ID == "Friend" && Link11PriAmp == "General" && Link11IDAmp == "RTB")
			{				
				Link16ID = "Friend";
				Link16Plat = "N.S.";
				Link16Act = "Return to Base (RTB)";
			}	
			else if (Link11ID == "Friend" && Link11PriAmp == "Helo" && Link11IDAmp == "N.S.")
			{				
				Link16ID = "Friend";
				Link16Plat = "Helicopter (HELO)";
				Link16Act = "N.S.";
			}	
			else if (Link11ID == "Friend" && Link11PriAmp == "Helo" && Link11IDAmp == "ASW")
			{				
				Link16ID = "Friend";
				Link16Plat = "Antisubmarine Warfare Helicopter (ASW HELO)";
				Link16Act = "N.S.";
			}					
			else if (Link11ID == "Friend" && Link11PriAmp == "Helo" && Link11IDAmp == "SAR")
			{				
				Link16ID = "Friend";
				Link16Plat = "Helicopter (HELO)";
				Link16Act = "Search and Rescue (SAR)";
			}		
			else if (Link11ID == "Friend" && Link11PriAmp == "Helo" && Link11IDAmp == "Gun Ship")
			{				
				Link16ID = "Friend";
				Link16Plat = "Helicopter Gunship";
				Link16Act = "N.S.";
			}				
			else if (Link11ID == "Friend" && Link11PriAmp == "Helo" && Link11IDAmp == "RECON/RECCE")
			{				
				Link16ID = "Friend";
				Link16Plat = "Helicopter (HELO)";
				Link16Act = "Reconnaissance";
			}		
			else if (Link11ID == "Friend" && Link11PriAmp == "Helo" && Link11IDAmp == "Logisitc")
			{				
				Link16ID = "Friend";
				Link16Plat = "Transport Helicopter";
				Link16Act = "Logistics Support";
			}		
			else if (Link11ID == "Friend" && Link11PriAmp == "Helo" && Link11IDAmp == "Trooplift")
			{				
				Link16ID = "Friend";
				Link16Plat = "Transport Helicopter";
				Link16Act = "Trooplift";
			}		
			else if (Link11ID == "Friend" && Link11PriAmp == "Helo" && Link11IDAmp == "MEDEVAC")
			{				
				Link16ID = "Friend";
				Link16Plat = "Transport Helicopter";
				Link16Act = "Medical Evacuation (MEDEVAC)";
			}				
			else if (Link11ID == "Friend" && Link11PriAmp == "Strike/Support/Bomber" && Link11IDAmp == "N.S.")
			{				
				Link16ID = "Friend";
				Link16Plat = "Bomber";
				Link16Act = "N.S.";
			}	
			else if (Link11ID == "Friend" && Link11PriAmp == "Strike/Support/Bomber" && Link11IDAmp == "ASW")
			{				
				Link16ID = "Friend";
				Link16Plat = "Antisubmarine Warfare (ASW)";
				Link16Act = "N.S.";
			}				
			else if (Link11ID == "Friend" && Link11PriAmp == "Strike/Support/Bomber" && Link11IDAmp == "Tanker (GENERAL)")
			{				
				Link16ID = "Friend";
				Link16Plat = "Tanker";
				Link16Act = "N.S.";
			}				
			else if (Link11ID == "Friend" && Link11PriAmp == "Strike/Support/Bomber" && Link11IDAmp == "Tanker (BOOM)")
			{				
				Link16ID = "Friend";
				Link16Plat = "Tanker (Boom Only)";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Friend" && Link11PriAmp == "Strike/Support/Bomber" && Link11IDAmp == "Tanker (DROGUE)")
			{				
				Link16ID = "Friend";
				Link16Plat = "Tanker (Drogue Only)";
				Link16Act = "N.S.";
			}					
			else if (Link11ID == "Friend" && Link11PriAmp == "Strike/Support/Bomber" && Link11IDAmp == "CAS/DAS")
			{				
				Link16ID = "Friend";
				Link16Plat = "Close Air Support (CAS)";
				Link16Act = "N.S.";
			}				
			else if (Link11ID == "Friend" && Link11PriAmp == "Strike/Support/Bomber" && Link11IDAmp == "Logisitc")
			{				
				Link16ID = "Friend";
				Link16Plat = "Logistc";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Friend" && Link11PriAmp == "Strike/Support/Bomber" && Link11IDAmp == "Interdiction")
			{				
				Link16ID = "Friend";
				Link16Plat = "N.S.";
				Link16Act = "Interdiction";
			}					
			else if (Link11ID == "Friend" && Link11PriAmp == "Int/Fighter" && Link11IDAmp == "N.S.")
			{				
				Link16ID = "Friend";
				Link16Plat = "Fighter";
				Link16Act = "N.S.";
			}				
			else if (Link11ID == "Friend" && Link11PriAmp == "Int/Fighter" && Link11IDAmp == "RESCAP")
			{				
				Link16ID = "Friend";
				Link16Plat = "Fighter";
				Link16Act = "Rescue Combat Air Patrol (RESCAP)";
			}						
			else if (Link11ID == "Friend" && Link11PriAmp == "Int/Fighter" && Link11IDAmp == "CAP")
			{				
				Link16ID = "Friend";
				Link16Plat = "Fighter";
				Link16Act = "Combat Air Patrol (CAP)";
			}					
			else if (Link11ID == "Friend" && Link11PriAmp == "Int/Fighter" && Link11IDAmp == "CAP")
			{				
				Link16ID = "Friend";
				Link16Plat = "Fighter";
				Link16Act = "Combat Air Patrol (CAP)";
			}					
			else if (Link11ID == "Friend" && Link11PriAmp == "Int/Fighter" && Link11IDAmp == "RTB")
			{				
				Link16ID = "Friend";
				Link16Plat = "Fighter";
				Link16Act = "Return to Base (RTB)";
			}				
			else if (Link11ID == "Friend" && Link11PriAmp == "Int/Fighter" && Link11IDAmp == "Drone/RPV")
			{				
				Link16ID = "Friend";
				Link16Plat = "Drone";
				Link16Act = "N.S.";
			}					
			else if (Link11ID == "Friend" && Link11PriAmp == "Special Mission" && Link11IDAmp == "N.S.")
			{				
				Link16ID = "Friend";
				Link16Plat = "N.S.";
				Link16Act = "Special";
			}				
			else if (Link11ID == "Friend" && Link11PriAmp == "Special Mission" && Link11IDAmp == "AEW/ARP/ABCCC")
			{				
				Link16ID = "Friend";
				Link16Plat = "Airborne Early Warning and Control (AEW)";
				Link16Act = "Special";
			}			
			else if (Link11ID == "Friend" && Link11PriAmp == "Special Mission" && Link11IDAmp == "SAR")
			{				
				Link16ID = "Friend";
				Link16Plat = "Search and Rescue (SAR)";
				Link16Act = "Special";
			}					
			else if (Link11ID == "Friend" && Link11PriAmp == "Special Mission" && Link11IDAmp == "EW")
			{				
				Link16ID = "Friend";
				Link16Plat = "Electronic Warfare";
				Link16Act = "N.S.";
			}					
			else if (Link11ID == "Friend" && Link11PriAmp == "Special Mission" && Link11IDAmp == "RECON/RECCE")
			{				
				Link16ID = "Friend";
				Link16Plat = "Reconnaissance";
				Link16Act = "N.S.";
			}				
			else
			{
				Link16ID = "Invalid";
				Link16Plat = "Invalid";
				Link16Act = "Invalid";
			}			
			
			L16ID = Link16ID;
			L16Plat = Link16Plat;
			L16Act = Link16Act;
		}		
		
		//************************************************************************************//
		//************************Link 11 to Link 16 Surface Conversion***********************//
		//************************************************************************************//		
		
		public void Convert_SurfaceL11_L16(string Link11ID, string Link11PriAmp, string Link11IDAmp, out string L16ID, out string L16Plat, out string L16Act)
		{
			string Link16ID;
			string Link16Plat;
			string Link16Act;
			
			//*****************************ID PENDING****************************//
			
			if (Link11ID == "Unknown" && Link11PriAmp == "Pending" && Link11IDAmp == "N.S.")
			{				
				Link16ID = "Pending";
				Link16Plat = "N.S.";
				Link16Act = "N.S.";
			}
			
			//*****************************ID UNKNOWN****************************//
			
			else if (Link11ID == "Unknown" && Link11PriAmp == "Unknown" && Link11IDAmp == "Aircraft Carrier")
			{				
				Link16ID = "Unknown";
				Link16Plat = "Aircraft Carrier";
				Link16Act = "N.S.";
			}
			else if (Link11ID == "Unknown" && Link11PriAmp == "Unknown" && Link11IDAmp == "CG/DD")
			{				
				Link16ID = "Unknown";
				Link16Plat = "Cruiser";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Unknown" && Link11PriAmp == "Unknown" && Link11IDAmp == "PB/PG")
			{				
				Link16ID = "Unknown";
				Link16Plat = "Fast Patrol Boat";
				Link16Act = "N.S.";
			}		
			else if (Link11ID == "Unknown" && Link11PriAmp == "Unknown" && Link11IDAmp == "Amphibious")
			{				
				Link16ID = "Unknown";
				Link16Plat = "Amphibious";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Unknown" && Link11PriAmp == "Unknown" && Link11IDAmp == "Nonmil")
			{				
				Link16ID = "Unknown";
				Link16Plat = "Non-Military";
				Link16Act = "N.S.";
			}					
			else if (Link11ID == "Unknown" && Link11PriAmp == "Unknown" && Link11IDAmp == "Surfaced Submarine")
			{				
				Link16ID = "Unknown";
				Link16Plat = "Surfaced Submarine";
				Link16Act = "N.S.";
			}	
			else if (Link11ID == "Unknown" && Link11PriAmp == "Unknown" && Link11IDAmp == "SIGINT")
			{				
				Link16ID = "Unknown";
				Link16Plat = "Intelligence Collector";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Unknown" && Link11PriAmp == "Unknown" && Link11IDAmp == "N.S.")
			{				
				Link16ID = "Unknown";
				Link16Plat = "N.S.";
				Link16Act = "N.S.";
			}				
			
			//**************************ID ASSUMED FRIEND**************************//

			else if (Link11ID == "Unknown" && Link11PriAmp == "Assumed Friend" && Link11IDAmp == "Aircraft Carrier")
			{				
				Link16ID = "Assumed Friend";
				Link16Plat = "Aircraft Carrier";
				Link16Act = "N.S.";
			}
			else if (Link11ID == "Unknown" && Link11PriAmp == "Assumed Friend" && Link11IDAmp == "CG/DD")
			{				
				Link16ID = "Assumed Friend";
				Link16Plat = "Cruiser";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Unknown" && Link11PriAmp == "Assumed Friend" && Link11IDAmp == "PB/PG")
			{				
				Link16ID = "Assumed Friend";
				Link16Plat = "Fast Patrol Boat";
				Link16Act = "N.S.";
			}		
			else if (Link11ID == "Unknown" && Link11PriAmp == "Assumed Friend" && Link11IDAmp == "Amphibious")
			{				
				Link16ID = "Assumed Friend";
				Link16Plat = "Amphibious";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Unknown" && Link11PriAmp == "Assumed Friend" && Link11IDAmp == "Nonmil")
			{				
				Link16ID = "Assumed Friend";
				Link16Plat = "Non-Military";
				Link16Act = "N.S.";
			}					
			else if (Link11ID == "Unknown" && Link11PriAmp == "Assumed Friend" && Link11IDAmp == "Surfaced Submarine")
			{				
				Link16ID = "Assumed Friend";
				Link16Plat = "Surfaced Submarine";
				Link16Act = "N.S.";
			}	
			else if (Link11ID == "Unknown" && Link11PriAmp == "Assumed Friend" && Link11IDAmp == "SIGINT")
			{				
				Link16ID = "Assumed Friend";
				Link16Plat = "Intelligence Collector";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Unknown" && Link11PriAmp == "Assumed Friend" && Link11IDAmp == "N.S.")
			{				
				Link16ID = "Assumed Friend";
				Link16Plat = "N.S.";
				Link16Act = "N.S.";
			}								
			
			//*****************************ID SUSPECT****************************//

			else if (Link11ID == "Unknown" && Link11PriAmp == "Suspect" && Link11IDAmp == "Aircraft Carrier")
			{				
				Link16ID = "Suspect";
				Link16Plat = "Aircraft Carrier";
				Link16Act = "N.S.";
			}
			else if (Link11ID == "Unknown" && Link11PriAmp == "Suspect" && Link11IDAmp == "CG/DD")
			{				
				Link16ID = "Suspect";
				Link16Plat = "Cruiser";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Suspect" && Link11PriAmp == "Suspect" && Link11IDAmp == "CG/DD")
			{				
				Link16ID = "Suspect";
				Link16Plat = "Cruiser";
				Link16Act = "N.S.";
			}					
			else if (Link11ID == "Unknown" && Link11PriAmp == "Suspect" && Link11IDAmp == "PB/PG")
			{				
				Link16ID = "Suspect";
				Link16Plat = "Fast Patrol Boat";
				Link16Act = "N.S.";
			}		
			else if (Link11ID == "Unknown" && Link11PriAmp == "Suspect" && Link11IDAmp == "Amphibious")
			{				
				Link16ID = "Suspect";
				Link16Plat = "Amphibious";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Unknown" && Link11PriAmp == "Suspect" && Link11IDAmp == "Nonmil")
			{				
				Link16ID = "Suspect";
				Link16Plat = "Non-Military";
				Link16Act = "N.S.";
			}					
			else if (Link11ID == "Unknown" && Link11PriAmp == "Suspect" && Link11IDAmp == "Surfaced Submarine")
			{				
				Link16ID = "Suspect";
				Link16Plat = "Surfaced Submarine";
				Link16Act = "N.S.";
			}	
			else if (Link11ID == "Unknown" && Link11PriAmp == "Suspect" && Link11IDAmp == "SIGINT")
			{				
				Link16ID = "Suspect";
				Link16Plat = "Intelligence Collector";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Unknown" && Link11PriAmp == "Suspect" && Link11IDAmp == "N.S.")
			{				
				Link16ID = "Suspect";
				Link16Plat = "N.S.";
				Link16Act = "N.S.";
			}	
			
			//*****************************ID HOSTILE*****************************//

			else if (Link11ID == "Hostile" && Link11PriAmp == "General" && Link11IDAmp == "Aircraft Carrier")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Aircraft Carrier";
				Link16Act = "N.S.";
			}
			else if (Link11ID == "Hostile" && Link11PriAmp == "General" && Link11IDAmp == "CG/DD")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Cruiser";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Hostile" && Link11PriAmp == "General" && Link11IDAmp == "PB/PG")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Fast Patrol Boat";
				Link16Act = "N.S.";
			}		
			else if (Link11ID == "Hostile" && Link11PriAmp == "General" && Link11IDAmp == "Amphibious")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Amphibious";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Hostile" && Link11PriAmp == "General" && Link11IDAmp == "Nonmil")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Non-Military";
				Link16Act = "N.S.";
			}					
			else if (Link11ID == "Hostile" && Link11PriAmp == "General" && Link11IDAmp == "Surfaced Submarine")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Surfaced Submarine";
				Link16Act = "N.S.";
			}	
			else if (Link11ID == "Hostile" && Link11PriAmp == "General" && Link11IDAmp == "SIGINT")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Intelligence Collector";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Hostile" && Link11PriAmp == "General" && Link11IDAmp == "N.S.")
			{				
				Link16ID = "Hostile";
				Link16Plat = "N.S.";
				Link16Act = "N.S.";
			}				
			
			//*****************************ID NEUTRAL****************************//
			
			else if (Link11ID == "Friend" && Link11PriAmp == "General" && Link11IDAmp == "Neutral")
			{				
				Link16ID = "Neutral";
				Link16Plat = "N.S.";
				Link16Act = "N.S.";
			}			
			
			//*****************************ID FRIEND*****************************//

			else if (Link11ID == "Friend" && Link11PriAmp == "Special Mission" && Link11IDAmp == "N.S.")
			{				
				Link16ID = "Friend";
				Link16Plat = "N.S.";
				Link16Act = "Special Warfare";
			}				
			else if (Link11ID == "Friend" && Link11PriAmp == "Special Mission" && Link11IDAmp == "PB/PG")
			{				
				Link16ID = "Friend";
				Link16Plat = "Fast Patrol Boat";
				Link16Act = "N.S.";
			}		
			else if (Link11ID == "Friend" && Link11PriAmp == "Special Mission" && Link11IDAmp == "Minelayer")
			{				
				Link16ID = "Friend";
				Link16Plat = "Mine Warfare Ship";
				Link16Act = "Minelaying)";
			}	
			else if (Link11ID == "Friend" && Link11PriAmp == "Special Mission" && Link11IDAmp == "Ocean Research")
			{				
				Link16ID = "Friend";
				Link16Plat = "Helicopter (HELO)";
				Link16Act = "N.S.";
			}	
			else if (Link11ID == "Friend" && Link11PriAmp == "Special Mission" && Link11IDAmp == "SIGINT")
			{				
				Link16ID = "Friend";
				Link16Plat = "Intelligence Collecting";
				Link16Act = "N.S.";
			}					
			else if (Link11ID == "Friend" && Link11PriAmp == "Special Mission" && Link11IDAmp == "ACV/Hydro")
			{				
				Link16ID = "Friend";
				Link16Plat = "Air Cushion Vehicle";
				Link16Act = "N.S.";
			}		
			else if (Link11ID == "Friend" && Link11PriAmp == "Special Mission" && Link11IDAmp == "Surfaced Submarine")
			{				
				Link16ID = "Friend";
				Link16Plat = "Surfaced Submarine";
				Link16Act = "N.S.";
			}				
			else if (Link11ID == "Friend" && Link11PriAmp == "Special Mission" && Link11IDAmp == "Minesweeper")
			{				
				Link16ID = "Friend";
				Link16Plat = "Mine Warfare Ship";
				Link16Act = "Mine Countermeasures";
			}		
			else if (Link11ID == "Friend" && Link11PriAmp == "Helo" && Link11IDAmp == "Logisitc")
			{				
				Link16ID = "Friend";
				Link16Plat = "Transport Helicopter";
				Link16Act = "Logistics Support";
			}		
			else if (Link11ID == "Friend" && Link11PriAmp == "Line" && Link11IDAmp == "N.S.")
			{				
				Link16ID = "Friend";
				Link16Plat = "Command";
				Link16Act = "N.S.";
			}		
			else if (Link11ID == "Friend" && Link11PriAmp == "Line" && Link11IDAmp == "Aircraft Carrier")
			{				
				Link16ID = "Friend";
				Link16Plat = "Aircraft Carrier";
				Link16Act = "N.S.";
			}				
			else if (Link11ID == "Friend" && Link11PriAmp == "Line" && Link11IDAmp == "CG")
			{				
				Link16ID = "Friend";
				Link16Plat = "Cruiser";
				Link16Act = "N.S.";
			}	
			else if (Link11ID == "Friend" && Link11PriAmp == "Liner" && Link11IDAmp == "BB")
			{				
				Link16ID = "Friend";
				Link16Plat = "Battleship";
				Link16Act = "N.S.";
			}				
			else if (Link11ID == "Friend" && Link11PriAmp == "Line" && Link11IDAmp == "DD")
			{				
				Link16ID = "Friend";
				Link16Plat = "Destroyer";
				Link16Act = "N.S.";
			}				
			else if (Link11ID == "Friend" && Link11PriAmp == "Line" && Link11IDAmp == "FF")
			{				
				Link16ID = "Friend";
				Link16Plat = "Frigate";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Friend" && Link11PriAmp == "Line" && Link11IDAmp == "Patrol Craft")
			{				
				Link16ID = "Friend";
				Link16Plat = "Patrol";
				Link16Act = "N.S.";
			}					
			else if (Link11ID == "Friend" && Link11PriAmp == "Amphibious" && Link11IDAmp == "N.S.")
			{				
				Link16ID = "Friend";
				Link16Plat = "Amphibious";
				Link16Act = "N.S.";
			}				
			else if (Link11ID == "Friend" && Link11PriAmp == "Amphibious" && Link11IDAmp == "Land Platform")
			{				
				Link16ID = "Friend";
				Link16Plat = "Landing Platform";
				Link16Act = "N.S.";
			}			
			else if (Link11ID == "Friend" && Link11PriAmp == "Amphibious" && Link11IDAmp == "Landing Ship")
			{				
				Link16ID = "Friend";
				Link16Plat = "Landing Ship";
				Link16Act = "N.S.";
			}					
			else if (Link11ID == "Friend" && Link11PriAmp == "Amphibious" && Link11IDAmp == "Landing Craft")
			{				
				Link16ID = "Friend";
				Link16Plat = "Landing Craft (LC)";
				Link16Act = "N.S.";
			}				
			else if (Link11ID == "Friend" && Link11PriAmp == "Amphibious" && Link11IDAmp == "Troop")
			{				
				Link16ID = "Friend";
				Link16Plat = "Troop Ship";
				Link16Act = "Amphibious Warfare";
			}						
			else if (Link11ID == "Friend" && Link11PriAmp == "Amphibious" && Link11IDAmp == "Cargo")
			{				
				Link16ID = "Friend";
				Link16Plat = "Auxiliary Ship Support";
				Link16Act = "Amphibious Warfare";
			}					
			else if (Link11ID == "Friend" && Link11PriAmp == "Amphibious" && Link11IDAmp == "Command")
			{				
				Link16ID = "Friend";
				Link16Plat = "Amphibious Assault Command Ship (LCC)";
				Link16Act = "N.S.";
			}					
			else if (Link11ID == "Friend" && Link11PriAmp == "Amphibious" && Link11IDAmp == "LHA/LHD")
			{				
				Link16ID = "Friend";
				Link16Plat = "LHA/LHD";
				Link16Act = "N.S.";			}				
		
			else if (Link11ID == "Friend" && Link11PriAmp == "General" && Link11IDAmp == "N.S.")
			{				
				Link16ID = "Friend";
				Link16Plat = "N.S.";
				Link16Act = "N.S.";
			}				
			else
			{
				Link16ID = "Invalid";
				Link16Plat = "Invalid";
				Link16Act = "Invalid";
			}			
			
			L16ID = Link16ID;
			L16Plat = Link16Plat;
			L16Act = Link16Act;
		}	
		
		//************************************************************************************//
		//***********************Link 11 to Link 16 Subsurface Conversion*********************//
		//************************************************************************************//		
		
		public void Convert_SubsurfaceL11_L16(string Link11ID, string Link11Mission, out string L16ID, out string L16Act)
		{
			string Link16ID;
			string Link16Act;
			
			//*****************************ID PENDING****************************//
			
			if (Link11ID == "Pending" && Link11Mission == "ANTISHIPPING")
			{				
				Link16ID = "Pending";
				Link16Act = "Antisurface Warfare";
			}			
			else if (Link11ID == "Pending" && Link11Mission == "ANTISUBMARINE")
			{				
				Link16ID = "Pending";
				Link16Act = "Antisubmarine Warfare (ASW)";
			}			
			else if (Link11ID == "Pending" && Link11Mission == "RECONNAISSANCE")
			{				
				Link16ID = "Pending";
				Link16Act = "Reconnaissance";
			}					
			else if (Link11ID == "Pending" && Link11Mission == "MINELAYING")
			{				
				Link16ID = "Pending";
				Link16Act = "Minelaying";
			}					
			else if (Link11ID == "Pending" && Link11Mission == "TRANSITING")
			{				
				Link16ID = "Pending";
				Link16Act = "Transiting";
			}					
			else if (Link11ID == "Pending" && Link11Mission == "SPECIAL/SAR")
			{				
				Link16ID = "Pending";
				Link16Act = "Search And Rescue (SAR)";
			}
			else if (Link11ID == "Pending" && Link11Mission == "ESCORT")
			{				
				Link16ID = "Pending";
				Link16Act = "Escorting";
			}			
			else if (Link11ID == "Pending" && Link11Mission == "N.S.")
			{				
				Link16ID = "Pending";
				Link16Act = "N.S.";
			}					
			
			//*****************************ID UNKNOWN****************************//
			
			else if (Link11ID == "Unknown" && Link11Mission == "ANTISHIPPING")
			{				
				Link16ID = "Unknown";
				Link16Act = "Antisurface Warfare";
			}			
			else if (Link11ID == "Unknown" && Link11Mission == "ANTISUBMARINE")
			{				
				Link16ID = "Unknown";
				Link16Act = "Antisubmarine Warfare (ASW)";
			}			
			else if (Link11ID == "Unknown" && Link11Mission == "RECONNAISSANCE")
			{				
				Link16ID = "Unknown";
				Link16Act = "Reconnaissance";
			}					
			else if (Link11ID == "Unknown" && Link11Mission == "MINELAYING")
			{				
				Link16ID = "Unknown";
				Link16Act = "Minelaying";
			}					
			else if (Link11ID == "Unknown" && Link11Mission == "TRANSITING")
			{				
				Link16ID = "Unknown";
				Link16Act = "Transiting";
			}					
			else if (Link11ID == "Unknown" && Link11Mission == "SPECIAL/SAR")
			{				
				Link16ID = "Unknown";
				Link16Act = "Search And Rescue (SAR)";
			}
			else if (Link11ID == "Unknown" && Link11Mission == "ESCORT")
			{				
				Link16ID = "Unknown";
				Link16Act = "Escorting";
			}		
			else if (Link11ID == "Unknown" && Link11Mission == "N.S.")
			{				
				Link16ID = "Unknown";
				Link16Act = "N.S.";
			}						
			
			//**************************ID ASSUMED FRIEND**************************//

			else if (Link11ID == "Assumed Friend" && Link11Mission == "ANTISHIPPING")
			{				
				Link16ID = "Assumed Friend";
				Link16Act = "Antisurface Warfare";
			}			
			else if (Link11ID == "Assumed Friend" && Link11Mission == "ANTISUBMARINE")
			{				
				Link16ID = "Assumed Friend";
				Link16Act = "Antisubmarine Warfare (ASW)";
			}			
			else if (Link11ID == "Assumed Friend" && Link11Mission == "RECONNAISSANCE")
			{				
				Link16ID = "Assumed Friend";
				Link16Act = "Reconnaissance";
			}					
			else if (Link11ID == "Assumed Friend" && Link11Mission == "MINELAYING")
			{				
				Link16ID = "Assumed Friend";
				Link16Act = "Minelaying";
			}					
			else if (Link11ID == "Assumed Friend" && Link11Mission == "TRANSITING")
			{				
				Link16ID = "Assumed Friend";
				Link16Act = "Transiting";
			}					
			else if (Link11ID == "Assumed Friend" && Link11Mission == "SPECIAL/SAR")
			{				
				Link16ID = "Assumed Friend";
				Link16Act = "Search And Rescue (SAR)";
			}
			else if (Link11ID == "Assumed Friend" && Link11Mission == "ESCORT")
			{				
				Link16ID = "Assumed Friend";
				Link16Act = "Escorting";
			}									
			else if (Link11ID == "Assumed Friend" && Link11Mission == "N.S.")
			{				
				Link16ID = "Assumed Friend";
				Link16Act = "N.S.";
			}				
			//*****************************ID SUSPECT****************************//

			else if (Link11ID == "Suspect" && Link11Mission == "ANTISHIPPING")
			{				
				Link16ID = "Suspect";
				Link16Act = "Antisurface Warfare";
			}			
			else if (Link11ID == "Suspect" && Link11Mission == "ANTISUBMARINE")
			{				
				Link16ID = "Suspect";
				Link16Act = "Antisubmarine Warfare (ASW)";
			}			
			else if (Link11ID == "Suspect" && Link11Mission == "RECONNAISSANCE")
			{				
				Link16ID = "Suspect";
				Link16Act = "Reconnaissance";
			}					
			else if (Link11ID == "Suspect" && Link11Mission == "MINELAYING")
			{				
				Link16ID = "Suspect";
				Link16Act = "Minelaying";
			}					
			else if (Link11ID == "Suspect" && Link11Mission == "TRANSITING")
			{				
				Link16ID = "Suspect";
				Link16Act = "Transiting";
			}					
			else if (Link11ID == "Suspect" && Link11Mission == "SPECIAL/SAR")
			{				
				Link16ID = "Suspect";
				Link16Act = "Search And Rescue (SAR)";
			}
			else if (Link11ID == "Suspect" && Link11Mission == "ESCORT")
			{				
				Link16ID = "Suspect";
				Link16Act = "Escorting";
			}		
			else if (Link11ID == "Suspect" && Link11Mission == "N.S.")
			{				
				Link16ID = "Suspect";
				Link16Act = "N.S.";
			}					
			
			//*****************************ID HOSTILE*****************************//

			else if (Link11ID == "Hostile" && Link11Mission == "ANTISHIPPING")
			{				
				Link16ID = "Hostile";
				Link16Act = "Antisurface Warfare";
			}			
			else if (Link11ID == "Hostile" && Link11Mission == "ANTISUBMARINE")
			{				
				Link16ID = "Hostile";
				Link16Act = "Antisubmarine Warfare (ASW)";
			}			
			else if (Link11ID == "Hostile" && Link11Mission == "RECONNAISSANCE")
			{				
				Link16ID = "Hostile";
				Link16Act = "Reconnaissance";
			}					
			else if (Link11ID == "Hostile" && Link11Mission == "MINELAYING")
			{				
				Link16ID = "Hostile";
				Link16Act = "Minelaying";
			}					
			else if (Link11ID == "Hostile" && Link11Mission == "TRANSITING")
			{				
				Link16ID = "Hostile";
				Link16Act = "Transiting";
			}					
			else if (Link11ID == "Hostile" && Link11Mission == "SPECIAL/SAR")
			{				
				Link16ID = "Hostile";
				Link16Act = "Search And Rescue (SAR)";
			}
			else if (Link11ID == "Hostile" && Link11Mission == "ESCORT")
			{				
				Link16ID = "Hostile";
				Link16Act = "Escorting";
			}				
			else if (Link11ID == "Hostile" && Link11Mission == "N.S.")
			{				
				Link16ID = "Hostile";
				Link16Act = "N.S.";
			}					
			
			//*****************************ID NEUTRAL****************************//
			
			else if (Link11ID == "Neutral" && Link11Mission == "ANTISHIPPING")
			{				
				Link16ID = "Neutral";
				Link16Act = "Antisurface Warfare";
			}			
			else if (Link11ID == "Neutral" && Link11Mission == "ANTISUBMARINE")
			{				
				Link16ID = "Neutral";
				Link16Act = "Antisubmarine Warfare (ASW)";
			}			
			else if (Link11ID == "Neutral" && Link11Mission == "RECONNAISSANCE")
			{				
				Link16ID = "Neutral";
				Link16Act = "Reconnaissance";
			}					
			else if (Link11ID == "Neutral" && Link11Mission == "MINELAYING")
			{				
				Link16ID = "Neutral";
				Link16Act = "Minelaying";
			}					
			else if (Link11ID == "Neutral" && Link11Mission == "TRANSITING")
			{				
				Link16ID = "Neutral";
				Link16Act = "Transiting";
			}					
			else if (Link11ID == "Neutral" && Link11Mission == "SPECIAL/SAR")
			{				
				Link16ID = "Neutral";
				Link16Act = "Search And Rescue (SAR)";
			}
			else if (Link11ID == "Neutral" && Link11Mission == "ESCORT")
			{				
				Link16ID = "Neutral";
				Link16Act = "Escorting";
			}		
			else if (Link11ID == "Neutral" && Link11Mission == "N.S.")
			{				
				Link16ID = "Neutral";
				Link16Act = "N.S.";
			}								
			
			//*****************************ID FRIEND*****************************//

			else if (Link11ID == "Friend" && Link11Mission == "ANTISHIPPING")
			{				
				Link16ID = "Friend";
				Link16Act = "Antisurface Warfare";
			}			
			else if (Link11ID == "Friend" && Link11Mission == "ANTISUBMARINE")
			{				
				Link16ID = "Friend";
				Link16Act = "Antisubmarine Warfare (ASW)";
			}			
			else if (Link11ID == "Friend" && Link11Mission == "RECONNAISSANCE")
			{				
				Link16ID = "Friend";
				Link16Act = "Reconnaissance";
			}					
			else if (Link11ID == "Friend" && Link11Mission == "MINELAYING")
			{				
				Link16ID = "Friend";
				Link16Act = "Minelaying";
			}					
			else if (Link11ID == "Friend" && Link11Mission == "TRANSITING")
			{				
				Link16ID = "Friend";
				Link16Act = "Transiting";
			}					
			else if (Link11ID == "Friend" && Link11Mission == "SPECIAL/SAR")
			{				
				Link16ID = "Friend";
				Link16Act = "Search And Rescue (SAR)";
			}
			else if (Link11ID == "Friend" && Link11Mission == "ESCORT")
			{				
				Link16ID = "Friend";
				Link16Act = "Escorting";
			}				
			else if (Link11ID == "Friend" && Link11Mission == "N.S.")
			{				
				Link16ID = "Friend";
				Link16Act = "N.S.";
			}				
			else
			{
				Link16ID = "Invalid";
				Link16Act = "Invalid";
			}			
			
			L16ID = Link16ID;
			L16Act = Link16Act;
		}			
		
		//************************************************************************************//
		//**************************Link 11 to Link 16 Land Conversion************************//
		//************************************************************************************//		
		
		public void Convert_LandL11_L16(string Link11Point, string Link11PointAmp, out string L16ID, out string L16Plat, out string L16PointType)
		{
			string Link16ID;
			string Link16Plat;
			string Link16PointType;
			
			//****************ID PENDING/UKNOWN/ASUMMED FRIEND/NEUTRAL****************//
			
			if (Link11Point == "RADAR" && Link11PointAmp == "N.S.")
			{				
				Link16ID = "Friend";
				Link16Plat = "Radar Site";
				Link16PointType = null;
			}			
			else if (Link11Point == "REFERENCE POINT (GENERAL)" && Link11PointAmp == "N.S.")
			{				
				Link16ID = null;
				Link16Plat = null;
				Link16PointType = "Reference Point (General)";
			}			
						
			//**************************ID SUSPECT/HOSTILE*************************//

			else if (Link11Point == "ENEMY POINT" && Link11PointAmp == "Troop Concentration")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Troop Concentration/Unit";
				Link16PointType = null;
			}			
			else if (Link11Point == "ENEMY POINT" && Link11PointAmp == "Air Base")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Airfield/Airbase";
				Link16PointType = null;
			}			
			else if (Link11Point == "ENEMY POINT" && Link11PointAmp == "SAM Site")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Surface-to-Air Missile (SAM) Site";
				Link16PointType = null;
			}			
			else if (Link11Point == "ENEMY POINT" && Link11PointAmp == "Artillery")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Field Artillery";
				Link16PointType = null;
			}		
			else if (Link11Point == "ENEMY POINT" && Link11PointAmp == "Convoy")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Convoy";
				Link16PointType = null;
			}		
			else if (Link11Point == "ENEMY POINT" && Link11PointAmp == "Rail")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Train";
				Link16PointType = null;
			}		
			else if (Link11Point == "ENEMY POINT" && Link11PointAmp == "Bridge")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Bridge";
				Link16PointType = null;
			}				
			else if (Link11Point == "ENEMY POINT" && Link11PointAmp == "N.S.")
			{				
				Link16ID = "Hostile";
				Link16Plat = "N.S.";
				Link16PointType = null;
			}					
		
			//*****************************ID FRIEND*****************************//

			else if (Link11Point == "SUPPORT UNIT (SU)" && Link11PointAmp == "MHQ")
			{				
				Link16ID = "Friend";
				Link16Plat = "Maritime Headquarters";
				Link16PointType = null;
			}			
			else if (Link11Point == "SUPPORT UNIT (SU)" && Link11PointAmp == "Air Base")
			{				
				Link16ID = "Friend";
				Link16Plat = "Airfield/Airbase";
				Link16PointType = null;
			}	
			else if (Link11Point == "SUPPORT UNIT (SU)" && Link11PointAmp == "SAM Site")
			{				
				Link16ID = "Friend";
				Link16Plat = "Surface-to-Air Missile (SAM) Site";
				Link16PointType = null;
			}			
			else if (Link11Point == "SUPPORT UNIT (SU)" && Link11PointAmp == "ASRT")
			{				
				Link16ID = "Friend";
				Link16Plat = "Air Support Radar Team (ASRT)";
				Link16PointType = null;
			}	
			else if (Link11Point == "SUPPORT UNIT (SU)" && Link11PointAmp == "DASC")
			{				
				Link16ID = "Friend";
				Link16Plat = "Direct Air Support Center (DASC)";
				Link16PointType = null;
			}		
			else if (Link11Point == "SUPPORT UNIT (SU)" && Link11PointAmp == "FACP")
			{				
				Link16ID = "Friend";
				Link16Plat = "Forward Air Control Party (FACP)/Tactical Air Control Party (TACP)";
				Link16PointType = null;
			}		
			else if (Link11Point == "SUPPORT UNIT (SU)" && Link11PointAmp == "ADA/BOC/TDS")
			{				
				Link16ID = "Friend";
				Link16Plat = "Air Defense Artillery";
				Link16PointType = null;
			}		
			else if (Link11Point == "SUPPORT UNIT (SU)" && Link11PointAmp == "N.S.")
			{				
				Link16ID = "Friend";
				Link16Plat = "N.S.";
				Link16PointType = null;
			}					
			else
			{
				Link16ID = "Invalid";
				Link16Plat = "Invalid";
				Link16PointType = "Invalid";
			}			
			
			L16ID = Link16ID;
			L16Plat = Link16Plat;
			L16PointType = Link16PointType;
		}		
		
		//************************************************************************************//
		//*************************Link 11 to Link 16 Space Conversion************************//
		//************************************************************************************//		
		
		public void Convert_SpaceL11_L16(string Link11ID, string Link11Point, string Link11PointAmp, out string L16ID, out string L16Plat, out string L16Act)
		{
			string Link16ID;
			string Link16Plat;
			string Link16Act;
			
			//******************************ID PENDING******************************//
			
			if (Link11ID == "Unknown" && Link11Point == "Pending" && Link11PointAmp == "N.S.")
			{				
				Link16ID = "Pending";
				Link16Plat = "N.S.";
				Link16Act = "N.S.";
			}		
						
			//********************************UKNOWN********************************//

			else if (Link11ID == "Unknown" && Link11Point == "Unknown" && Link11PointAmp == "N.S.")
			{				
				Link16ID = "Unknown";
				Link16Plat = "N.S.";
				Link16Act = "N.S.";
			}			
			
			//***************************ASSUMED FRIEND****************************//

			else if (Link11ID == "Unknown" && Link11Point == "Assumed Friend" && Link11PointAmp == "N.S.")
			{				
				Link16ID = "Assumed Friend";
				Link16Plat = "N.S.";
				Link16Act = "N.S.";
			}		
			
			//*******************************NEUTRAL*******************************//

			else if (Link11ID == "Friend" && Link11Point == "General" && Link11PointAmp == "Neutral")
			{				
				Link16ID = "Neutral";
				Link16Plat = "N.S.";
				Link16Act = "N.S.";
			}				
			
			//*******************************SUSPECT*******************************//

			else if (Link11ID == "Unknown" && Link11Point == "Suspect" && Link11PointAmp == "N.S.")
			{				
				Link16ID = "Suspect";
				Link16Plat = "N.S.";
				Link16Act = "N.S.";
			}			
			
			//*******************************HOSTILE*******************************//

			else if (Link11ID == "Hostile" && Link11Point == "General" && Link11PointAmp == "Missile")
			{				
				Link16ID = "Hostile";
				Link16Plat = "Missile";
				Link16Act = "N.S.";
			}				
		
			//*****************************ID FRIEND*****************************//

			else if (Link11ID == "Friend" && Link11Point == "General" && Link11PointAmp == "Missile")
			{				
				Link16ID = "Friend";
				Link16Plat = "Missile";
				Link16Act = "N.S.";
			}					
			else
			{
				Link16ID = "Invalid";
				Link16Plat = "Invalid";
				Link16Act= "Invalid";
			}			
			
			L16ID = Link16ID;
			L16Plat = Link16Plat;
			L16Act = Link16Act;
		}			
	}
}		

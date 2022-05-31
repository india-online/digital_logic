Directory structure
Overall Structure
├───code                                                         
│   ├───Assets**                           
│   │   ├───Resources                    
│   │   │   ├───Prefabs                     
│   │   │   └───Sprites                  
│   │   ├───Scenes                       
│   │   └───Scripts                // project code             
│   │       └───UnitTests	       // unit tests for the project code (and any other tests)                                           
├───design   				           // UML diagrams                           
├───doc                               // documentation plus Report #3, presentation slides, etc.	          


**Inner structure of the code/Assets/ Directory where all the code, and art assets are stored.
The scripts folder hold all of our program C# code.

├───Resources                                                                                                                     
│   ├───Prefabs       //folder stores all of the preset GameObjects for easy loading in code                                                                                                                
│   └───Sprites        //folder that contains all art assets created for this project                                                                                              
├───Scenes             //folder that contains all 'scenes' that can be loaded by unity, these are preset metadata for GameObjects that are automatically loaded on scene loading                                                                                 
└───Scripts  //Main folder where all of the project's classes are stored                                                                  
    │   AddSubtract.cs                             //Helper class that allows the Protoboard device to extend or reduce its size                                     
    │   AdminButtonManager.cs           //Button click listeners implemented for the Admin Subsystem
    │   AdminScrollView.cs                     //Loads grading information from the database and places them in preset geometric locations in the UI                                          
    │   ANDGate.cs                                  //Class that controls behavior of the AND device                              
    │   CheckerTagScript.cs                    //Helper class that supports the lab grading system                                  
    │   CreateUserScript.cs                   //Script that allows the Admin Subsystem to create a new user and store it in online database                                  
    │   DataInsert.cs                               //Database script that pulls in data from AWS                            
    │   Equipment.cs                             //Equipment loader class                               
    │   InputChecker.cs                          //Checks for 'Key' inputs from user, particularly for the Wire funcitonality                                
    │   INVGate.cs                                  //Class that controls behavior of the INV device                            
    │   Kmap.cs                                       //Script that sets up the KMAP for the postlabs                         
    │   LabOneGrader.cs                       //Script that checks in the input and outputs for lab 1                                        
    │   LabTwoGrader.cs                       //Script that checks in the input and outputs for lab 2                                       
    │   Leaderboard.cs                          //Script that pulls in data from AWS and sets up the leaderboard in Student Subsystem                                    
    │   LEDScript.cs                                //Class that controls behavior of the LED device                                 
    │   LogicBehavior.cs                        //Class that handles the behavior of the Logic Nodes/Pins                                     
    │   LogicInterface.cs                       //Interface that allows each device to implement it                                     
    │   LogicManager.cs                       //Class that stores all active Logic Nodes and resets them when nessesary                                      
    │   Login.cs                                       //Class that sets up the Login Screen and checks the Username and Password with AWS database                              
    │   MagnifierBehavior.cs                //Class that controls behavior of the device inspector                                         
    │   MainMenuButton.cs                //Script for the main menu button                                            
    │   MUXGate.cs                               //Class that controls behavior of the MUX device                                     
    │   NANDGate.cs                             //Class that controls behavior of the NAND device                                                          
    │   ORGate.cs                                  //Class that controls behavior of the OR device                                  
    │   PostLab1.cs                                //Script that sets up the Postlab 1 scene and checks for the correct output and grades it                                 
    │   PostLab2.cs                                //Script that sets up the Postlab 2 scene and checks for the correct output and grades it                                     
    │   PowerSupplyScript.cs               //Class that controls behavior of the Power Supply device                                         
    │   PreLab1.cs                                  //Script that sets up the Prelab 1 scene and checks for the correct output and grades it                                     
    │   Prelab2Script.cs                         //Script that sets up the Prelab 2 scene and checks for the correct output and grades it                                        
    │   ProtoboardObject.cs                 //Class that controls behavior of the Protoboard device   
    │   StudentSubsystem.cs                //Script that handles the set up of the Student Subsystem, including Button listeners                                         
    │   Switch.cs                                      //Class that controls behavior of the Switch (SPDT) device                                 
    │   Toast.cs                                        //Script that allows us to use a "Toast" UI element                             
    │   TrashBehavior.cs                         //Script that allows for Destruction of any active devices                                   
    │   TruthTable.cs                               //Truth table script to help set up the prelab                              
    │   Webcam.cs                                  //Script that sets up the Webcam and saves it to storage                                    
    │   Wire.cs                                         //Class that controls behavior of the Wire device                                
    │   WireInflection.cs                        //Helper class that controls behavior of the AND device                                      
    │   XORGate.cs                                  //Class that controls behavior of the XOR device                                                                                                         
    └───UnitTests //Folder within the project where the unit and integration tests are kept                                                              
            EquipmentTests.cs                //Runs unit tests on all the equipment                                        
            IntegrationTesting.cs            //Integration test for lab one                                         
            PostlabTests.cs                      //Test for the post labs                                    
            PrelabTests.cs                        //Test for the pre labs     
Thanks!  SURESH       
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			
                          

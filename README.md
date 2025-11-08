# Traffic Lights Simulator

A simple Windows Forms application that simulates a UK traffic light system, created as a practice project for learning VB.NET.

## About

This is a practice VB.NET project I completed during class to learn Windows Forms development, Visual Basic programming concepts, and state management. The application simulates a realistic UK traffic light sequence with both manual control and automatic cycling.

## Features

- Accurate UK traffic light sequence (Red → Red+Amber → Green → Amber → Red)
- Manual control buttons for each light state
- Automatic cycling with configurable timer
- "Change Light" button for step-by-step progression
- Start/Stop timer controls
- Visual representation using traffic light images

## Technical Details

- **Language**: Visual Basic .NET
- **Framework**: .NET 8.0 (Windows)
- **UI Framework**: Windows Forms
- **IDE**: Visual Studio 2022

## Traffic Light Sequence

The application follows the standard UK traffic light sequence:

1. **Red** - Stop
2. **Red + Amber** - Prepare to go
3. **Green** - Go
4. **Amber** - Prepare to stop
5. Back to **Red**

## Learning Objectives

This project helped me practice:

- Windows Forms design and layout
- Timer controls and event handling
- State management in applications
- Arrays and indexing
- Select Case statements
- Resource management for images
- Button event handlers in VB.NET
- UI/UX principles for simulation

## How to Run

1. Open `TrafficLights.sln` in Visual Studio
2. Build the solution (F6)
3. Run the application (F5)
4. Use the buttons to control the traffic light manually or start the automatic timer

## Controls

- **Red** - Set light to red
- **Red/Amber** - Set light to red and amber
- **Green** - Set light to green
- **Amber** - Set light to amber
- **Change Light** - Progress to next state in sequence
- **Start Timer** - Begin automatic cycling (2 second intervals)
- **Stop Timer** - Stop automatic cycling
- **Exit** - Close the application

## Code Structure

- `Form1.vb` - Main form logic and traffic light state management
- `Form1.Designer.vb` - UI layout and control definitions
- `ApplicationEvents.vb` - Application-level event handlers
- `My Project/` - Auto-generated project files and application settings
- `assets/` - Traffic light images (red.png, amber.png, green.png, red_amber.png)

## License

This project is licensed under the GNU General Public License v3.0 - see the [LICENSE](LICENSE) file for details.

## Note

This is a student practice project created for educational purposes. The application logic is intentionally simple to focus on learning VB.NET fundamentals and state management concepts.

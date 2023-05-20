# DiscordRichPresenceMinecraftDungeons

## Introduction

This project is a purely educational proof of concept (PoC) created with the intention of providing insights into the extraction, parsing, and display of data from the game Minecraft Dungeons. 
The goal is to showcase features like the current level and difficulty in Discord's rich presence.
Although the project is functional and can be theoretically utilized, it is important to note that it is not designed for commercial purposes and will not be transformed into a marketable product.
Its primary objective is to serve as a learning tool, enabling the author and other interested individuals to gain a better understanding of the technical aspects involved in this process.

## How

To inspect the communication of Minecraft Dungeons, I used Fiddler Classic (https://www.telerik.com/fiddler/fiddler-classic). 
By examining the data flow and understanding its origin and destination (https://sessiondirectory.xboxlive.com/serviceconfigs), I discovered certain values that I required. 
I extracted the data from those connections, parsed it into the XboxServiceResponse object, and utilized it. 
I experimented with various methods and libraries to capture the data, and among the different options, only Fiddler.Core proved to be effective.

## Why

I couldn't find any existing software specifically designed for Discord's rich presence in Minecraft Dungeons, and the "DungeonsRPC" repository on GitHub is no longer functional according to the mentioned issues.
Out of curiosity, I decided to explore the feasibility of implementing Discord's rich presence in Minecraft Dungeons using available libraries. To my surprise, I was able to create a working proof of concept using a few resources and code.
However, it's important to note that this implementation is a simple attempt and does not cover all the features of rich presence, nor does it meet security standards (using self-signed root-certificates).

## Technologies

The project is built using the following technologies:
- .NET Framework 4.8
- [Fiddler.Core](https://www.nuget.org/packages/FiddlerCore/4.6.2) (the .NET Framework version) for decrypting the communication and extracting the data.
- [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json) for parsing the data.
- [DiscordRichPresence](https://www.nuget.org/packages/DiscordRichPresence) for displaying the data in Discord.

## Features

The main features of this project include:
- Gathering and displaying the active level in Minecraft Dungeons in Discord's rich presence, along with the difficulty if available.
- Providing a button to allow others to add your Xbox user directly through a button in the rich presence display.
- The timer and levelname reset every time you start a new level or return to the lobby.

## Screenshot(s)

![Example RichPresence](https://raw.githubusercontent.com/liebki/DiscordRichPresenceMinecraftDungeons/master/Screenshots/Example-RichPresence.PNG)

## Usage

1. Download the project, build it and start the created "DiscordRichPresenceMinecraftDungeons.exe"
2. Install the certificate by selecting "Yes" the window popping up should look like this: 
![Fiddler Certificate Window](https://www.telerik.com/sfimages/default-source/blogs/image_thumb-5--png-png)
3. After selecting "yes" the software should be hidden and after using dungeons, the rich presence should change the content

OR

- See the test-section one below

Information:
- Please note that the Rich Presence may not be immediately visible or updated upon starting the application. It typically changes and becomes active once you have started the first level in the game.
- If you stop the application using ALT + F4 or experience a crash, the proxy is NOT automatically removed from the system, and you may lose internet connection. In such cases, you need to manually disable the proxy in the Windows settings, it should look like this at the end:
![Disable the custom Fiddler proxy](https://www.ionos.de/digitalguide/fileadmin/DigitalGuide/Screenshots/proxy-einstellungen-unter-windows-10.png)
- In the event of a program closure or crash, the Rich Presence may persist and cannot be automatically removed. As a result, it may continue indefinitely until you restart Discord.
- You should press Enter two times when no longer needing the application, then it ends gracefully and everything is disposed, this is the way until I add some kind of application termination event to handle it.

## Test

If you want to test the software using my application and application ID, feel free to contact me on Discord: ncmy#5863. 
Alternatively, you can create your own application by visiting the Discord Developer Portal at https://discord.com/developers/applications/ and replace my application ID with yours in the code snippet: new DiscordRpcClient("your_application_id_here");

## Disclaimer and license (IMPORTANT)

Please read the full disclaimer (DISCLAIMER.txt) and the license of fiddler.core (Fiddler.Core-LICENSE.txt) before using this project in any way. 
The author (liebki) of the project and the project itself are not endorsed by Telerik and do not reflect the views or opinions of Telerik or any individuals officially involved with the project.

Important things to note:

- When utilizing Fiddler, it installs root-certificates and directs all traffic through these and this application, please note that I cannot guarantee the safety of the data collected by Fiddler.Core. The Minecraft Dungeons Rich Presence application solely gathers the essential data for updating the RPC and does not retain any information permanently. It also waits for the detection of the Dungeons.exe process before operating.
- The certificates generated and installed by Fiddler may pose a risk if vulnerabilities are present. To mitigate potential issues, it is advisable to remove all certificates from the certificate store in Windows (accessible via WIN + R > certmgr.msc) when they are no longer necessary. These certificates typically begin with "DO_NOT_TRUST_XXXXXXXXXXXXXXXXX..."
![Fiddler certificates in certmgr.ms](https://s3.amazonaws.com/cdn.freshdesk.com/data/helpdesk/attachments/production/12082337741/original/-VRgbBpBa0cw2MBYtZuUAJeKqg6Cw2b57g.png)
- This program is exclusively compatible with Windows as it is developed using the .NET Framework.
- Again; I want to emphasize that I am not liable for any damages or consequences resulting from the use of this program. Additionally, I cannot be held responsible for any actions taken by others using this software. This project is purely a test and aims to provide a nice-to-have feature.

## Image Sources

- Fiddler certificates in certmgr.ms
	- Source: https://community.getfiddler.com/support/discussions/topics/12000025605
	- Image: https://s3.amazonaws.com/cdn.freshdesk.com/data/helpdesk/attachments/production/12082337741/original/-VRgbBpBa0cw2MBYtZuUAJeKqg6Cw2b57g.png

- Disable the custom Fiddler proxy 
	- Source: https://www.ionos.de/digitalguide/server/konfiguration/so-richten-sie-einen-proxy-server-im-browser-ein/
	- (https://www.ionos.de/digitalguide/fileadmin/DigitalGuide/Screenshots/proxy-einstellungen-unter-windows-10.png)

- Fiddler Certificate Window 
	- Source: https://www.telerik.com/blogs/faq---certificates-in-fiddler
	- (https://www.telerik.com/sfimages/default-source/blogs/image_thumb-5--png-png)
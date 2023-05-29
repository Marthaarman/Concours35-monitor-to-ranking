# Concours35 monitor to vmix ranking

Vmix is able to read CSV files as data source for graphics. Using the "uitslag naar monitor" function in the concours35 satelliet program, the tool fills a CSV file for vmix based on the ranking in the satelliet program. 

# Setup

### shared folder
A shared folder between the device running the sateliet program and the vmix device is required. Create a shared folder on one device and make the other connect to it using windows file explorer. 
On the top of your file explorer screen click "Add a network location" (Netwerk locatie toevoegen) and type in the path of the device with the shared folder. 

### Concours35 Satelliet
Hit the settings button and then "mappen". In monitor springen enter the path to the shared folder
Hit the "uitslag naar monitor" checkmark on the satelliet program

### vmix device
open the tool, click the "select output folder" button and select the path to which a csv file should be written. This file will later be used by vmix.
With the "Select .DAT file" button you can select the concours35 satelliet .DAT file with "uitslag" in the name. Note that a first result must be entered before this file will be located in the shared folder. 
Once the first result is there and the file exists, you can select it and then hit "run".

### vmix
Select the .csv file which is located in the selected output folder as data source for your graphics. You can select the row for the desired ranking to display. 



# Rocket  // Odyssey Week 7

### Rocket Elevators New REST API



### **How to answer the 9 questions in Postman :** 


#### 1- *To Get a specified Battery current status, do* : </br>
&nbsp;&nbsp;&nbsp;&nbsp;**GET** https://rocketapi.azure-api.net/api/batteries/5		_[5 = specified battery ID]_ </br>
&nbsp;&nbsp;&nbsp;&nbsp;**SEND**
  
#### 2- *To Modify the status of a specified Battery, do* : </br>
&nbsp;&nbsp;&nbsp;&nbsp;**PUT** https://rocketapi.azure-api.net/api/batteries/5		_[5 = specified battery ID]_ </br>
&nbsp;&nbsp;&nbsp;&nbsp;**SEND** </br>
&nbsp;&nbsp;&nbsp;&nbsp;An error will appear in the field, that's ok. </br>
&nbsp;&nbsp;&nbsp;&nbsp;**Select:**	&nbsp;Body </br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Raw </br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;JSON application </br>
&nbsp;&nbsp;&nbsp;&nbsp;In the text field, enter: </br>
```
{
	"status": "Active" _or_ "Inactive"  _to change the status_ 
} 
```
&nbsp;&nbsp;&nbsp;&nbsp;**SEND** </br>
&nbsp;&nbsp;&nbsp;&nbsp;You can verify if the change succeeded by doing a new GET on that specified Battery. 

#### 3- *To Get a specified Column current status, do* : </br>
&nbsp;&nbsp;&nbsp;&nbsp;GET https://rocketapi.azure-api.net/api/columns/5  _[5 = specified column ID]_ </br>
&nbsp;&nbsp;&nbsp;&nbsp;SEND 
  
#### 4- *To Modify the status of a specified Column, do* : </br>
&nbsp;&nbsp;&nbsp;&nbsp;PUT https://rocketapi.azure-api.net/api/columns/5  _[5 = specified column ID]_ </br>
&nbsp;&nbsp;&nbsp;&nbsp;SEND </br>
&nbsp;&nbsp;&nbsp;&nbsp;An error will appear in the field, that's ok. </br>
&nbsp;&nbsp;&nbsp;&nbsp;Select:	&nbsp;Body </br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Raw </br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;JSON application </br>
&nbsp;&nbsp;&nbsp;&nbsp;In the text field, enter: </br>
```
{ 
	"status": "Active" _or_ "Inactive"  _to change the status_ 
} 
```
&nbsp;&nbsp;&nbsp;&nbsp;SEND </br>
&nbsp;&nbsp;&nbsp;&nbsp;You can verify if the change succeeded by doing a new GET on that specified Column. 

#### 5- *To Get a specified Elevator current status, do* : </br>
&nbsp;&nbsp;&nbsp;&nbsp;GET https://rocketapi.azure-api.net/api/elevators/5  _[5 = specified elevator ID]_ </br>
&nbsp;&nbsp;&nbsp;&nbsp;SEND
  
#### 6- *To Modify the status of a specified Elevator, do* : </br>
&nbsp;&nbsp;&nbsp;&nbsp;PUT https://rocketapi.azure-api.net/api/elevators/5  _[5 = specified elevator ID]_ </br>
&nbsp;&nbsp;&nbsp;&nbsp;SEND </br>
&nbsp;&nbsp;&nbsp;&nbsp;An error will appear in the field, that's ok. </br>
&nbsp;&nbsp;&nbsp;&nbsp;Select:	&nbsp;Body </br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Raw </br>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;JSON application </br>
&nbsp;&nbsp;&nbsp;&nbsp;In the text field, enter: </br>
```
{ 
	"status": "Active" _or_ "Inactive"  _to change the status_ 
} 
```
&nbsp;&nbsp;&nbsp;&nbsp;SEND </br>
&nbsp;&nbsp;&nbsp;&nbsp;You can verify if the change succeeded by doing a new GET on that specified Elevator.

#### 7- *To Get the elevators list that are not in use at the moment (with the status "Inactive" or "Alarm"), do* : </br>
&nbsp;&nbsp;&nbsp;&nbsp;GET https://rocketapi.azure-api.net/api/elevators </br>
&nbsp;&nbsp;&nbsp;&nbsp;SEND 
	
#### 8- *To Get a buildings list that have at least one Battery, one Column or one Elevator needing an intervention, do* : </br>
&nbsp;&nbsp;&nbsp;&nbsp;GET https://rocketapi.azure-api.net/api/buildings </br>
&nbsp;&nbsp;&nbsp;&nbsp;SEND
	
#### 9- *To Get a Leads list that are not our clients yet since the last 30 days, do* : </br>
&nbsp;&nbsp;&nbsp;&nbsp;GET https://rocketapi.azure-api.net/api/leads </br>
&nbsp;&nbsp;&nbsp;&nbsp;SEND 
</br>
</br>
</br>

#### Authors : 
David Boutin, Luna-Victoria Leclerc, Dany Boucher, Dominic Bonneau and Valerie Beaupre 
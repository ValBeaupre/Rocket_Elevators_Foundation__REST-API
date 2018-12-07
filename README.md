# Rocket Elevators Foundation - REST API

### Interventions Management

### **All the "GET" endpoints can be viewed in the browser at this adress, adding the specific endpoint at the end of this url :** https://rocketfoundationrestapi.azurewebsites.net/api/interventions

### **How to answer the questions in Postman :**

#### 1- _To Get the full intervention list, do_ : </br>

&nbsp;&nbsp;&nbsp;&nbsp;**GET** https://rocketfoundationrestapi.azurewebsites.net/api/interventions/all </br> &nbsp;&nbsp;&nbsp;&nbsp;**SEND** </br>

#### 2- _To Get the intervention list with the "Pending" status and NO Starting Time, do_ : </br>

&nbsp;&nbsp;&nbsp;&nbsp;**GET** https://rocketfoundationrestapi.azurewebsites.net/api/interventions/pending </br> &nbsp;&nbsp;&nbsp;&nbsp;**SEND** </br>

#### 3- _To Get the intervention list with the "In Progress" status, do_ : </br>

&nbsp;&nbsp;&nbsp;&nbsp;**GET** https://rocketfoundationrestapi.azurewebsites.net/api/interventions/inprogresslist </br> &nbsp;&nbsp;&nbsp;&nbsp;**SEND** </br>

#### 4- _To Get a specified intervention current status, do_ : </br>

&nbsp;&nbsp;&nbsp;&nbsp;**GET** https://rocketfoundationrestapi.azurewebsites.net/api/interventions/33 _[33 = specified battery ID]_ </br> &nbsp;&nbsp;&nbsp;&nbsp;**SEND** </br>

#### 5- _To Modify a specified intervention status from "Pending" to "In Progress" with a starting time, do_ : </br>

&nbsp;&nbsp;&nbsp;&nbsp;**PUT** https://rocketfoundationrestapi.azurewebsites.net/api/interventions/inprogress/33 _[33 = specified battery ID]_ </br> &nbsp;&nbsp;&nbsp;&nbsp;**SEND** </br>

&nbsp;&nbsp;&nbsp;&nbsp;You can verify if the change succeeded by doing a new GET on that specified Intervention (step #4). </br>

#### 6- _To Modify a specified intervention status from "In Progress" to "Completed" with an ending time, do_ : </br>

&nbsp;&nbsp;&nbsp;&nbsp;**PUT** https://rocketfoundationrestapi.azurewebsites.net/api/interventions/completed/33 _[33 = specified battery ID]_ </br> &nbsp;&nbsp;&nbsp;&nbsp;**SEND** </br>

&nbsp;&nbsp;&nbsp;&nbsp;You can verify if the change succeeded by doing a new GET on that specified Intervention (step #4).

</br> </br> </br>

#### Author :

Valerie Beaupre

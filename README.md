# Welcome to the MinDef github repository!!!

The mindef project

# current hosting: NetLab
we are currently hosting the application on the NetLab server owned by FHICT. To access this server you will need a fontys vpn (cisco).
once connected to the vpn you can access the application on [192.168.220.45](192.168.220.45)
and can manage the server at: [https://vcenter.fhict.local/ui/app/vm;nav=h/urn:vmomi:VirtualMachine:vm-23476613:705BE42C-681E-44C4-994F-D3D8B75D4D6A/summary](https://vcenter.fhict.local/ui/app/vm;nav=h/urn:vmomi:VirtualMachine:vm-23476613:705BE42C-681E-44C4-994F-D3D8B75D4D6A/summary)

connect using ssh using the credentials, which you can receive from a team member.

# Getting started (Kubernetes)

- find a place with kubernetes installed to host the application
- ```sudo microk8s enable ingress dns metrics-server storage```

### cookie for rabbitmq services communication
- ```echo -n "some secret key" > cookie```
- ```kubectl create secret generic erlang-cookie --from-file=./cookie```
### for admin user
- ```echo -n "mindef" > user```
- ```echo -n "kldjlkh5ihfikjfn4" > pass```
- ```sudo microk8s kubectl create secret generic rabbitmq-admin --from-file=./user --from-file=./pass```
- ```rm pass```
- ```rm user```

### and now pull the repo
- ```git pull <this repository url"```
- ```cd MinDef/kubernetes```
- optionally edit the hostnames of the ingress to something appropiate 

and then
- ```sudo microk8s kubectl apply -f .```
- ```sudo microk8s kubectl apply -f ./frontend```
- etc. repeat for each folder

and thats it! your application should be up and running.

since the ingress makes use of host mapping, you should configure your OS's hostsfile to redirect the right (sub)domains to your application. 
in my case i've added:
```cs
# Mindef Hostname mapping
192.168.220.45 mindefdashboard.nl
192.168.220.45 api.mindefdashboard.nl
## development only
192.168.220.45 authservice.mindefdashboard.nl
```
you probably need to restart your device for these changes to take into effect.

and thats it! your application should be up and running.
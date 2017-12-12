**Ping Count .NET CORE**

Application réalisé en .NET CORE

**Pré-requis**

Installer .Net CORE sur Linux

Lancer les commandes suivantes
```
curl https://packages.microsoft.com/keys/microsoft.asc | gpg --dearmor > microsoft.gpg
sudo mv microsoft.gpg /etc/apt/trusted.gpg.d/microsoft.gpg
sudo sh -c 'echo "deb [arch=amd64] https://packages.microsoft.com/repos/microsoft-ubuntu-xenial-prod xenial main" > /etc/apt/sources.list.d/dotnetdev.list'
```

Puis :

```
sudo apt-get update
sudo apt-get install dotnet-sdk-2.0.0
```


**Mise en route**

Se placer dans le dossier /Core-PingCount/PingCount
et lancer la commande 

```
dotnet run
```

**Utilisation**

2 routes existe : api/ping et api/count

 

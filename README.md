**Ping Count .NET CORE**

Application réalisé en .NET CORE

**Pré-requis**

**MacOS**

Installer le pkg : https://download.microsoft.com/download/5/D/F/5DF4B836-7DFD-4CCF-AC96-101E2A4C7421/dotnet-sdk-2.1.2-osx-gs-x64.pkg

**Ubuntu**

Installer jq et bc pour le script
```
apt-get install jq
apt-get install bc
```

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

 

# CryptoMonkey

CryptoMonkey is a proposed communications system that will provide secure bidirection communication between two endpoints by utilising rotational encryption based on asymmetric cryptography.

## CryptoMonkey Prototype

This repository will contain the prototype of the CryptoMonkey communication system that will be used to demonstrate the effectiveness of the technology.

The prototype will be developed using C# .Net Core 5.0 but the principles of the system mean that clients can communicate using software developed in a range of languages.

## Further Work

Once the C# prototype has been established working, clients may be developed in other programming languages to satisfy the concept that the communication will work on software developed in a range of languages.

The prototype will utilise data delivered using JSON.  The data will be manually copied between the sender and receiver clients in order to satisfy the requirements of the prototype.  Further work may be undertaken to automate the communicate between two clients using a real-time connection (perhaps via a TCP listener or WebSockets).

## Bugs, Issues, Suggestions

Please raise any bugs, issues, or suggestions via the [Issues](https://github.com/memiamap/cryptomonkey-proto/issues) page.  Try to use appropriate tags when creating these to help identify what it is you are raising.

## Cryptography

The precise cryptography to be used for the prototype is yet to be determined.  It will be an asymmetric encryption algorithm.  Future work may use EC-based encryption but the initial prototype is likely to utilise something build into .Net Core 5.0.
#!/bin/bash

if [[ ! -d certs ]]
then
    mkdir certs
    cd certs/
    if [[ ! -f localhost.pfx ]]
    then
        dotnet dev-certs https -v -ep localhost.pfx -p 3eefc93e-5453-4229-b420-33ca5a50a43d -t
    fi
    cd ../
fi

docker-compose up -d

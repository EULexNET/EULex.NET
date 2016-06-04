#!/usr/bin/env sh
wget "http://eur-lex.europa.eu/eurlex-ws?wsdl" -O eurlex-ws.wsdl
wget "http://eur-lex.europa.eu/eurlex-ws?xsd=3" -O eurlex-ws_3.xsd
wget "http://eur-lex.europa.eu/eurlex-ws?xsd=2" -O eurlex-ws_2.xsd
wget "http://eur-lex.europa.eu/eurlex-ws?xsd=1" -O eurlex-ws_1.xsd

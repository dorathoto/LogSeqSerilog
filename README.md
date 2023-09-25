# LogSeqSerilog

executar um SEQ via container

```
docker run --name seq -d --restart unless-stopped -e ACCEPT_EULA=Y -p 5341:80 datalust/seq:latest
```


Depois nele mesmo é possível configurar permissões, limite de dias de retenção;

Após executar acessar o SEQ e gerar uma chave de acesso, colar no program.cs

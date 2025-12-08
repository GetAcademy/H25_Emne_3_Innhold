# NGROK

Denne videoen vider hvordan man setter opp http-tunnel gratis med Ngrok: 

- https://www.youtube.com/watch?v=KcbUaZ2a4hc


Kort oppsummering: 
- lag konto på https://ngrok.com/
- last ned https://ngrok.com/download og installer
- Åpne cmd og gå til mappen hvor du har ngrok.exe
- Logg inn på https://ngrok.com/ og finn kommandoen ngrok config add-authtoken med din auth token 
- Kjør denne linjen i cmd
- Start backenden din. Om den kjører på feks https://localhost:7219 starter du en tunnel med 
  kommandoen ngrok http https://localhost:7219
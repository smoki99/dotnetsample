FROM microsoft/dotnet

RUN useradd -d /hwapp -m app

USER app
COPY . /hwapp
WORKDIR /hwapp
RUN ["dotnet", "restore"]

#EXPOSE 5000

CMD ["dotnet", "run"]
FROM node:12

RUN mkdir /app
WORKDIR /app

COPY ./AngularClient/package.json .

RUN npm install -g @angular/cli
RUN npm install

COPY ./AngularClient .

CMD ["ng", "serve", "--host", "0.0.0.0"]

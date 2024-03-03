### STAGE 1: Build ###
FROM node:18-alpine AS build
WORKDIR /app
COPY ["skakus.angular/package.json", "skakus.angular/package-lock.json", "./"]
RUN npm install
COPY skakus.angular/. .
RUN npm run build

### STAGE 2: Run ###
FROM nginx:latest
COPY skakus.angular/nginx.conf /etc/nginx/nginx.conf
COPY --from=build /app/dist/skakus/browser /usr/share/nginx/html

EXPOSE 8080
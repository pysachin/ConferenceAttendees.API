# use the official nginx image as the base
FROM nginx:latest

# remove the default configuration file provided by nginx
RUN rm /etc/nginx/conf.d/default.conf

# copy the custom nginx configuration file into the container
COPY nginx.conf /etc/nginx/nginx.conf

# setup directory for nginx logs (if not already present)
RUN mkdir -p /var/log/nginx
RUN touch /var/log/nginx/access.log /var/log/nginx/error.log

# expose port 80 to the hoost sp the nginx can serve HTTP traffic
EXPOSE 8083

# start nginx when the container launches using the default command
CMD ["nginx","-g","daemon off;"]
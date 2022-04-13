# Run Redis container with Docker

```
# run container
docker run -d --name redis-server -p 5000:6379 redis

# access cli
docker exec -it redis-server sh
redis-cli
```
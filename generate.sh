docker run --rm -v "$(pwd):/local" openapitools/openapi-generator-cli generate -i /local/v1.json -g csharp-netcore -o /local/output2 -c /local/config.json

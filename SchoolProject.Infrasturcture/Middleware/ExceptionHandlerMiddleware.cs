﻿using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using RentSystem.Infrasturcture.Bases;

namespace RentSystem.Infrasturcture.Middleware
{
    public class ExceptionHandlerMiddleware 
    {
        private readonly  RequestDelegate _next;
        public ExceptionHandlerMiddleware(RequestDelegate next)
        {
            _next = next;             
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                _next(context);
            }
            catch (Exception ex)
            {
                var response = context.Response;
                response.ContentType = "application/json";
                var responseModel = new ResponeViewModel<string>();
                switch (ex)
                { 
                    case InvalidCastException invalidCastException:
                        responseModel.Message = ex.Message;
                        responseModel.Succeeded= false;
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;
                    case UnauthorizedAccessException e:
                        responseModel.Message = ex.Message;
                        responseModel.Succeeded = false;
                        response.StatusCode = (int)HttpStatusCode.Unauthorized;
                        response.StatusCode = (int)HttpStatusCode.Unauthorized;
                        break;

                    case ValidationException e:
                        responseModel.Message = ex.Message;
                        responseModel.Succeeded = false;
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        response.StatusCode = (int)HttpStatusCode.UnprocessableEntity;
                        break;
                    case KeyNotFoundException e:
                        // not found error
                        responseModel.Message = ex.Message;
                        responseModel.Succeeded = false;
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        response.StatusCode = (int)HttpStatusCode.NotFound;
                        break;

                    case DbUpdateException e:
                        // can't update error
                        response.StatusCode = (int)HttpStatusCode.BadRequest;
                        break;
                    case Exception e:
                        if (e.GetType().ToString() == "ApiException")
                        {
                            responseModel.Message += e.Message;
                            responseModel.Message += e.InnerException == null ? "" : "\n" + e.InnerException.Message;
                            responseModel.StatusCode = HttpStatusCode.BadRequest;
                            response.StatusCode = (int)HttpStatusCode.BadRequest;
                        }
                        responseModel.Message = e.Message;
                        responseModel.Message += e.InnerException == null ? "" : "\n" + e.InnerException.Message;

                        responseModel.StatusCode = HttpStatusCode.InternalServerError;
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;

                    default:
                        // unhandled error
                        responseModel.Message = ex.Message;
                        responseModel.StatusCode = HttpStatusCode.InternalServerError;
                        response.StatusCode = (int)HttpStatusCode.InternalServerError;
                        break;
                }
                var result = JsonSerializer.Serialize(responseModel);

                await response.WriteAsync(result);
            }
        }
    }
}


global using AutoMapper;
global using Confluent.Kafka;
global using HealthChecks.UI.Client;
global using mas.Infra;
global using mas.Infra.Responsitories;
global using MediatR;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.AspNetCore.Diagnostics.HealthChecks;
global using Microsoft.AspNetCore.Mvc;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Caching.Memory;
global using Microsoft.Extensions.Diagnostics.HealthChecks;
global using msa.App.Application.Commands;
global using msa.App.Application.IntegrationEvents.Events;
global using msa.App.Application.Queries;
global using msa.App.BackgroudTask;
global using msa.App.Config;
global using msa.App.Extensions;
global using msa.App.HC;
global using msa.App.Mappings;
global using msa.App.NetMQ;
global using msa.Common.Events;
global using msa.Common.Utils;
global using msa.Domain.Aggregates;
global using msa.Domain.Aggregates.IInmemoryRepository;
global using msa.Domain.Events;
global using msa.Domain.SeedWork;
global using msa.Infra.Data;
global using msa.Infra.Repositories.InmemoryRepositories;
global using NetMQ;
global using NetMQ.Sockets;
global using Newtonsoft.Json;

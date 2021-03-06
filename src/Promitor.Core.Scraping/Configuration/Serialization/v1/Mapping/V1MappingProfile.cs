﻿using AutoMapper;
using Promitor.Core.Contracts;
using Promitor.Core.Contracts.ResourceTypes;
using Promitor.Core.Scraping.Configuration.Model;
using Promitor.Core.Scraping.Configuration.Model.Metrics;
using Promitor.Core.Scraping.Configuration.Serialization.v1.Model;
using Promitor.Core.Scraping.Configuration.Serialization.v1.Model.ResourceTypes;

namespace Promitor.Core.Scraping.Configuration.Serialization.v1.Mapping
{
    public class V1MappingProfile : Profile
    {
        public V1MappingProfile()
        {
            CreateMap<MetricsDeclarationV1, MetricsDeclaration>();
            CreateMap<AzureMetadataV1, AzureMetadata>();
            CreateMap<MetricDefaultsV1, MetricDefaults>();
            CreateMap<AggregationV1, Aggregation>();
            CreateMap<MetricDimensionV1, MetricDimension>();
            CreateMap<ScrapingV1, Configuration.Model.Scraping>();
            CreateMap<AzureMetricConfigurationV1, AzureMetricConfiguration>();
            CreateMap<MetricAggregationV1, MetricAggregation>();
            CreateMap<AzureResourceDiscoveryGroupDefinitionV1, AzureResourceDiscoveryGroup>();
            CreateMap<SecretV1, Secret>();

            CreateMap<ApiManagementResourceV1, ApiManagementResourceDefinition>();
            CreateMap<AppPlanResourceV1, AppPlanResourceDefinition>();
            CreateMap<BlobStorageResourceV1, BlobStorageResourceDefinition>();
            CreateMap<ContainerInstanceResourceV1, ContainerInstanceResourceDefinition>();
            CreateMap<ContainerRegistryResourceV1, ContainerRegistryResourceDefinition>();
            CreateMap<DeviceProvisioningServiceResourceV1, DeviceProvisioningServiceResourceDefinition>();
            CreateMap<CosmosDbResourceV1, CosmosDbResourceDefinition>();
            CreateMap<EventHubsResourceV1, EventHubResourceDefinition>();
            CreateMap<FileStorageResourceV1, FileStorageResourceDefinition>();
            CreateMap<FunctionAppResourceV1, FunctionAppResourceDefinition>();
            CreateMap<GenericResourceV1, GenericAzureResourceDefinition>();
            CreateMap<IoTHubResourceV1, IoTHubResourceDefinition>();
            CreateMap<KeyVaultResourceV1, KeyVaultResourceDefinition>();
            CreateMap<LogicAppResourceV1, LogicAppResourceDefinition>();
            CreateMap<NetworkInterfaceResourceV1, NetworkInterfaceResourceDefinition>();
            CreateMap<PostgreSqlResourceV1, PostgreSqlResourceDefinition>();
            CreateMap<RedisCacheResourceV1, RedisCacheResourceDefinition>();
            CreateMap<ServiceBusQueueResourceV1, ServiceBusQueueResourceDefinition>();
            CreateMap<SqlDatabaseResourceV1, SqlDatabaseResourceDefinition>();
            CreateMap<SqlManagedInstanceResourceV1, SqlManagedInstanceResourceDefinition>();
            CreateMap<SqlServerResourceV1, SqlServerResourceDefinition>();
            CreateMap<StorageAccountResourceV1, StorageAccountResourceDefinition>();
            CreateMap<StorageQueueResourceV1, StorageQueueResourceDefinition>();
            CreateMap<VirtualMachineResourceV1, VirtualMachineResourceDefinition>();
            CreateMap<VirtualMachineScaleSetResourceV1, VirtualMachineScaleSetResourceDefinition>();
            CreateMap<WebAppResourceV1, WebAppResourceDefinition>();

            CreateMap<MetricDefinitionV1, PrometheusMetricDefinition>();

            CreateMap<MetricDefinitionV1, MetricDefinition>()
                .ForMember(m => m.PrometheusMetricDefinition, o => o.MapFrom(v1 => v1));

            CreateMap<AzureResourceDefinitionV1, IAzureResourceDefinition>()
                .Include<ApiManagementResourceV1, ApiManagementResourceDefinition>()
                .Include<AppPlanResourceV1, AppPlanResourceDefinition>()
                .Include<BlobStorageResourceV1, BlobStorageResourceDefinition>()
                .Include<ContainerInstanceResourceV1, ContainerInstanceResourceDefinition>()
                .Include<ContainerRegistryResourceV1, ContainerRegistryResourceDefinition>()
                .Include<CosmosDbResourceV1, CosmosDbResourceDefinition>()
                .Include<DeviceProvisioningServiceResourceV1, DeviceProvisioningServiceResourceDefinition>()
                .Include<EventHubsResourceV1, EventHubResourceDefinition>()
                .Include<FileStorageResourceV1, FileStorageResourceDefinition>()
                .Include<FunctionAppResourceV1, FunctionAppResourceDefinition>()
                .Include<GenericResourceV1, GenericAzureResourceDefinition>()
                .Include<IoTHubResourceV1, IoTHubResourceDefinition>()
                .Include<KeyVaultResourceV1, KeyVaultResourceDefinition>()
                .Include<LogicAppResourceV1, LogicAppResourceDefinition>()
                .Include<NetworkInterfaceResourceV1, NetworkInterfaceResourceDefinition>()
                .Include<PostgreSqlResourceV1, PostgreSqlResourceDefinition>()
                .Include<RedisCacheResourceV1, RedisCacheResourceDefinition>()
                .Include<ServiceBusQueueResourceV1, ServiceBusQueueResourceDefinition>()
                .Include<SqlDatabaseResourceV1, SqlDatabaseResourceDefinition>()
                .Include<SqlManagedInstanceResourceV1, SqlManagedInstanceResourceDefinition>()
                .Include<SqlServerResourceV1, SqlServerResourceDefinition>()
                .Include<StorageAccountResourceV1, StorageAccountResourceDefinition>()
                .Include<StorageQueueResourceV1, StorageQueueResourceDefinition>()
                .Include<VirtualMachineResourceV1, VirtualMachineResourceDefinition>()
                .Include<VirtualMachineScaleSetResourceV1, VirtualMachineScaleSetResourceDefinition>()
                .Include<WebAppResourceV1, WebAppResourceDefinition>();
        }
    }
}

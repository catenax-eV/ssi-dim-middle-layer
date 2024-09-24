/********************************************************************************
 * Copyright (c) 2024 BMW Group AG
 * Copyright 2024 SAP SE or an SAP affiliate company and ssi-dim-middle-layer contributors.
 *
 * See the NOTICE file(s) distributed with this work for additional
 * information regarding copyright ownership.
 *
 * This program and the accompanying materials are made available under the
 * terms of the Apache License, Version 2.0 which is available at
 * https://www.apache.org/licenses/LICENSE-2.0.
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations
 * under the License.
 *
 * SPDX-License-Identifier: Apache-2.0
 ********************************************************************************/

// <auto-generated />
using Dim.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Dim.Migrations.Migrations
{
    [DbContext(typeof(DimDbContext))]
    partial class DimDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("dim")
                .UseCollation("en_US.utf8")
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Dim.Entities.Entities.Process", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset?>("LockExpiryDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("lock_expiry_date");

                    b.Property<int>("ProcessTypeId")
                        .HasColumnType("integer")
                        .HasColumnName("process_type_id");

                    b.Property<Guid>("Version")
                        .IsConcurrencyToken()
                        .HasColumnType("uuid")
                        .HasColumnName("version");

                    b.HasKey("Id")
                        .HasName("pk_processes");

                    b.HasIndex("ProcessTypeId")
                        .HasDatabaseName("ix_processes_process_type_id");

                    b.ToTable("processes", "dim");
                });

            modelBuilder.Entity("Dim.Entities.Entities.ProcessStep", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<DateTimeOffset>("DateCreated")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_created");

                    b.Property<DateTimeOffset?>("DateLastChanged")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("date_last_changed");

                    b.Property<string>("Message")
                        .HasColumnType("text")
                        .HasColumnName("message");

                    b.Property<Guid>("ProcessId")
                        .HasColumnType("uuid")
                        .HasColumnName("process_id");

                    b.Property<int>("ProcessStepStatusId")
                        .HasColumnType("integer")
                        .HasColumnName("process_step_status_id");

                    b.Property<int>("ProcessStepTypeId")
                        .HasColumnType("integer")
                        .HasColumnName("process_step_type_id");

                    b.HasKey("Id")
                        .HasName("pk_process_steps");

                    b.HasIndex("ProcessId")
                        .HasDatabaseName("ix_process_steps_process_id");

                    b.HasIndex("ProcessStepStatusId")
                        .HasDatabaseName("ix_process_steps_process_step_status_id");

                    b.HasIndex("ProcessStepTypeId")
                        .HasDatabaseName("ix_process_steps_process_step_type_id");

                    b.ToTable("process_steps", "dim");
                });

            modelBuilder.Entity("Dim.Entities.Entities.ProcessStepStatus", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("label");

                    b.HasKey("Id")
                        .HasName("pk_process_step_statuses");

                    b.ToTable("process_step_statuses", "dim");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Label = "TODO"
                        },
                        new
                        {
                            Id = 2,
                            Label = "DONE"
                        },
                        new
                        {
                            Id = 3,
                            Label = "SKIPPED"
                        },
                        new
                        {
                            Id = 4,
                            Label = "FAILED"
                        },
                        new
                        {
                            Id = 5,
                            Label = "DUPLICATE"
                        });
                });

            modelBuilder.Entity("Dim.Entities.Entities.ProcessStepType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("label");

                    b.HasKey("Id")
                        .HasName("pk_process_step_types");

                    b.ToTable("process_step_types", "dim");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Label = "CREATE_WALLET"
                        },
                        new
                        {
                            Id = 2,
                            Label = "CHECK_OPERATION"
                        },
                        new
                        {
                            Id = 3,
                            Label = "GET_COMPANY"
                        },
                        new
                        {
                            Id = 4,
                            Label = "GET_DID_DOCUMENT"
                        },
                        new
                        {
                            Id = 5,
                            Label = "CREATE_STATUS_LIST"
                        },
                        new
                        {
                            Id = 6,
                            Label = "SEND_CALLBACK"
                        },
                        new
                        {
                            Id = 7,
                            Label = "RETRIGGER_CREATE_WALLET"
                        },
                        new
                        {
                            Id = 8,
                            Label = "RETRIGGER_CHECK_OPERATION"
                        },
                        new
                        {
                            Id = 9,
                            Label = "RETRIGGER_GET_COMPANY"
                        },
                        new
                        {
                            Id = 10,
                            Label = "RETRIGGER_GET_DID_DOCUMENT"
                        },
                        new
                        {
                            Id = 11,
                            Label = "RETRIGGER_CREATE_STATUS_LIST"
                        },
                        new
                        {
                            Id = 12,
                            Label = "RETRIGGER_SEND_CALLBACK"
                        },
                        new
                        {
                            Id = 100,
                            Label = "CREATE_TECHNICAL_USER"
                        },
                        new
                        {
                            Id = 101,
                            Label = "GET_TECHNICAL_USER_DATA"
                        },
                        new
                        {
                            Id = 102,
                            Label = "GET_TECHNICAL_USER_SERVICE_KEY"
                        },
                        new
                        {
                            Id = 103,
                            Label = "SEND_TECHNICAL_USER_CREATION_CALLBACK"
                        },
                        new
                        {
                            Id = 104,
                            Label = "RETRIGGER_CREATE_TECHNICAL_USER"
                        },
                        new
                        {
                            Id = 105,
                            Label = "RETRIGGER_GET_TECHNICAL_USER_DATA"
                        },
                        new
                        {
                            Id = 106,
                            Label = "RETRIGGER_GET_TECHNICAL_USER_SERVICE_KEY"
                        },
                        new
                        {
                            Id = 107,
                            Label = "RETRIGGER_SEND_TECHNICAL_USER_CREATION_CALLBACK"
                        },
                        new
                        {
                            Id = 200,
                            Label = "DELETE_TECHNICAL_USER"
                        },
                        new
                        {
                            Id = 201,
                            Label = "SEND_TECHNICAL_USER_DELETION_CALLBACK"
                        },
                        new
                        {
                            Id = 202,
                            Label = "RETRIGGER_DELETE_TECHNICAL_USER"
                        },
                        new
                        {
                            Id = 203,
                            Label = "RETRIGGER_SEND_TECHNICAL_USER_DELETION_CALLBACK"
                        });
                });

            modelBuilder.Entity("Dim.Entities.Entities.ProcessType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    b.Property<string>("Label")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("label");

                    b.HasKey("Id")
                        .HasName("pk_process_types");

                    b.ToTable("process_types", "dim");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Label = "SETUP_DIM"
                        },
                        new
                        {
                            Id = 2,
                            Label = "TECHNICAL_USER"
                        });
                });

            modelBuilder.Entity("Dim.Entities.Entities.TechnicalUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("ClientId")
                        .HasColumnType("text")
                        .HasColumnName("client_id");

                    b.Property<byte[]>("ClientSecret")
                        .HasColumnType("bytea")
                        .HasColumnName("client_secret");

                    b.Property<int?>("EncryptionMode")
                        .HasColumnType("integer")
                        .HasColumnName("encryption_mode");

                    b.Property<Guid>("ExternalId")
                        .HasColumnType("uuid")
                        .HasColumnName("external_id");

                    b.Property<byte[]>("InitializationVector")
                        .HasColumnType("bytea")
                        .HasColumnName("initialization_vector");

                    b.Property<Guid?>("OperationId")
                        .HasColumnType("uuid")
                        .HasColumnName("operation_id");

                    b.Property<Guid>("ProcessId")
                        .HasColumnType("uuid")
                        .HasColumnName("process_id");

                    b.Property<Guid?>("ServiceKeyId")
                        .HasColumnType("uuid")
                        .HasColumnName("service_key_id");

                    b.Property<string>("TechnicalUserName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("technical_user_name");

                    b.Property<Guid>("TenantId")
                        .HasColumnType("uuid")
                        .HasColumnName("tenant_id");

                    b.Property<string>("TokenAddress")
                        .HasColumnType("text")
                        .HasColumnName("token_address");

                    b.HasKey("Id")
                        .HasName("pk_technical_users");

                    b.HasIndex("ProcessId")
                        .HasDatabaseName("ix_technical_users_process_id");

                    b.HasIndex("TenantId")
                        .HasDatabaseName("ix_technical_users_tenant_id");

                    b.ToTable("technical_users", "dim");
                });

            modelBuilder.Entity("Dim.Entities.Entities.Tenant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("BaseUrl")
                        .HasColumnType("text")
                        .HasColumnName("base_url");

                    b.Property<string>("Bpn")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("bpn");

                    b.Property<string>("ClientId")
                        .HasColumnType("text")
                        .HasColumnName("client_id");

                    b.Property<byte[]>("ClientSecret")
                        .HasColumnType("bytea")
                        .HasColumnName("client_secret");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uuid")
                        .HasColumnName("company_id");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("company_name");

                    b.Property<string>("Did")
                        .HasColumnType("text")
                        .HasColumnName("did");

                    b.Property<string>("DidDocumentLocation")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("did_document_location");

                    b.Property<string>("DidDownloadUrl")
                        .HasColumnType("text")
                        .HasColumnName("did_download_url");

                    b.Property<int?>("EncryptionMode")
                        .HasColumnType("integer")
                        .HasColumnName("encryption_mode");

                    b.Property<byte[]>("InitializationVector")
                        .HasColumnType("bytea")
                        .HasColumnName("initialization_vector");

                    b.Property<bool>("IsIssuer")
                        .HasColumnType("boolean")
                        .HasColumnName("is_issuer");

                    b.Property<Guid?>("OperationId")
                        .HasColumnType("uuid")
                        .HasColumnName("operation_id");

                    b.Property<Guid>("OperatorId")
                        .HasColumnType("uuid")
                        .HasColumnName("operator_id");

                    b.Property<Guid>("ProcessId")
                        .HasColumnType("uuid")
                        .HasColumnName("process_id");

                    b.Property<string>("TokenAddress")
                        .HasColumnType("text")
                        .HasColumnName("token_address");

                    b.Property<Guid?>("WalletId")
                        .HasColumnType("uuid")
                        .HasColumnName("wallet_id");

                    b.HasKey("Id")
                        .HasName("pk_tenants");

                    b.HasIndex("ProcessId")
                        .HasDatabaseName("ix_tenants_process_id");

                    b.ToTable("tenants", "dim");
                });

            modelBuilder.Entity("Dim.Entities.Entities.Process", b =>
                {
                    b.HasOne("Dim.Entities.Entities.ProcessType", "ProcessType")
                        .WithMany("Processes")
                        .HasForeignKey("ProcessTypeId")
                        .IsRequired()
                        .HasConstraintName("fk_processes_process_types_process_type_id");

                    b.Navigation("ProcessType");
                });

            modelBuilder.Entity("Dim.Entities.Entities.ProcessStep", b =>
                {
                    b.HasOne("Dim.Entities.Entities.Process", "Process")
                        .WithMany("ProcessSteps")
                        .HasForeignKey("ProcessId")
                        .IsRequired()
                        .HasConstraintName("fk_process_steps_processes_process_id");

                    b.HasOne("Dim.Entities.Entities.ProcessStepStatus", "ProcessStepStatus")
                        .WithMany("ProcessSteps")
                        .HasForeignKey("ProcessStepStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_process_steps_process_step_statuses_process_step_status_id");

                    b.HasOne("Dim.Entities.Entities.ProcessStepType", "ProcessStepType")
                        .WithMany("ProcessSteps")
                        .HasForeignKey("ProcessStepTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_process_steps_process_step_types_process_step_type_id");

                    b.Navigation("Process");

                    b.Navigation("ProcessStepStatus");

                    b.Navigation("ProcessStepType");
                });

            modelBuilder.Entity("Dim.Entities.Entities.TechnicalUser", b =>
                {
                    b.HasOne("Dim.Entities.Entities.Process", "Process")
                        .WithMany("TechnicalUsers")
                        .HasForeignKey("ProcessId")
                        .IsRequired()
                        .HasConstraintName("fk_technical_users_processes_process_id");

                    b.HasOne("Dim.Entities.Entities.Tenant", "Tenant")
                        .WithMany("TechnicalUsers")
                        .HasForeignKey("TenantId")
                        .IsRequired()
                        .HasConstraintName("fk_technical_users_tenants_tenant_id");

                    b.Navigation("Process");

                    b.Navigation("Tenant");
                });

            modelBuilder.Entity("Dim.Entities.Entities.Tenant", b =>
                {
                    b.HasOne("Dim.Entities.Entities.Process", "Process")
                        .WithMany("Tenants")
                        .HasForeignKey("ProcessId")
                        .IsRequired()
                        .HasConstraintName("fk_tenants_processes_process_id");

                    b.Navigation("Process");
                });

            modelBuilder.Entity("Dim.Entities.Entities.Process", b =>
                {
                    b.Navigation("ProcessSteps");

                    b.Navigation("TechnicalUsers");

                    b.Navigation("Tenants");
                });

            modelBuilder.Entity("Dim.Entities.Entities.ProcessStepStatus", b =>
                {
                    b.Navigation("ProcessSteps");
                });

            modelBuilder.Entity("Dim.Entities.Entities.ProcessStepType", b =>
                {
                    b.Navigation("ProcessSteps");
                });

            modelBuilder.Entity("Dim.Entities.Entities.ProcessType", b =>
                {
                    b.Navigation("Processes");
                });

            modelBuilder.Entity("Dim.Entities.Entities.Tenant", b =>
                {
                    b.Navigation("TechnicalUsers");
                });
#pragma warning restore 612, 618
        }
    }
}

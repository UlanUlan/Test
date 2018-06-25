namespace CarDB.DAL.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<backupfile> backupfile { get; set; }
        public virtual DbSet<backupfilegroup> backupfilegroup { get; set; }
        public virtual DbSet<backupmediafamily> backupmediafamily { get; set; }
        public virtual DbSet<backupmediaset> backupmediaset { get; set; }
        public virtual DbSet<backupset> backupset { get; set; }
        public virtual DbSet<log_shipping_monitor_alert> log_shipping_monitor_alert { get; set; }
        public virtual DbSet<log_shipping_monitor_primary> log_shipping_monitor_primary { get; set; }
        public virtual DbSet<log_shipping_monitor_secondary> log_shipping_monitor_secondary { get; set; }
        public virtual DbSet<log_shipping_primaries> log_shipping_primaries { get; set; }
        public virtual DbSet<log_shipping_primary_databases> log_shipping_primary_databases { get; set; }
        public virtual DbSet<log_shipping_primary_secondaries> log_shipping_primary_secondaries { get; set; }
        public virtual DbSet<log_shipping_secondary> log_shipping_secondary { get; set; }
        public virtual DbSet<log_shipping_secondary_databases> log_shipping_secondary_databases { get; set; }
        public virtual DbSet<MSdbms> MSdbms { get; set; }
        public virtual DbSet<MSdbms_datatype> MSdbms_datatype { get; set; }
        public virtual DbSet<MSdbms_datatype_mapping> MSdbms_datatype_mapping { get; set; }
        public virtual DbSet<MSdbms_map> MSdbms_map { get; set; }
        public virtual DbSet<restorehistory> restorehistory { get; set; }
        public virtual DbSet<syscachedcredentials> syscachedcredentials { get; set; }
        public virtual DbSet<syscollector_blobs_internal> syscollector_blobs_internal { get; set; }
        public virtual DbSet<syscollector_collection_items_internal> syscollector_collection_items_internal { get; set; }
        public virtual DbSet<syscollector_collection_sets_internal> syscollector_collection_sets_internal { get; set; }
        public virtual DbSet<syscollector_collector_types_internal> syscollector_collector_types_internal { get; set; }
        public virtual DbSet<syscollector_config_store_internal> syscollector_config_store_internal { get; set; }
        public virtual DbSet<syscollector_execution_log_internal> syscollector_execution_log_internal { get; set; }
        public virtual DbSet<syscollector_execution_stats_internal> syscollector_execution_stats_internal { get; set; }
        public virtual DbSet<sysdac_history_internal> sysdac_history_internal { get; set; }
        public virtual DbSet<sysdac_instances_internal> sysdac_instances_internal { get; set; }
        public virtual DbSet<sysdbmaintplans> sysdbmaintplans { get; set; }
        public virtual DbSet<sysjobstepslogs> sysjobstepslogs { get; set; }
        public virtual DbSet<sysmail_account> sysmail_account { get; set; }
        public virtual DbSet<sysmail_attachments_transfer> sysmail_attachments_transfer { get; set; }
        public virtual DbSet<sysmail_configuration> sysmail_configuration { get; set; }
        public virtual DbSet<sysmail_log> sysmail_log { get; set; }
        public virtual DbSet<sysmail_mailitems> sysmail_mailitems { get; set; }
        public virtual DbSet<sysmail_principalprofile> sysmail_principalprofile { get; set; }
        public virtual DbSet<sysmail_profile> sysmail_profile { get; set; }
        public virtual DbSet<sysmail_profileaccount> sysmail_profileaccount { get; set; }
        public virtual DbSet<sysmail_query_transfer> sysmail_query_transfer { get; set; }
        public virtual DbSet<sysmail_send_retries> sysmail_send_retries { get; set; }
        public virtual DbSet<sysmail_server> sysmail_server { get; set; }
        public virtual DbSet<sysmail_servertype> sysmail_servertype { get; set; }
        public virtual DbSet<sysmaintplan_log> sysmaintplan_log { get; set; }
        public virtual DbSet<sysmaintplan_subplans> sysmaintplan_subplans { get; set; }
        public virtual DbSet<sysmanagement_shared_registered_servers_internal> sysmanagement_shared_registered_servers_internal { get; set; }
        public virtual DbSet<sysmanagement_shared_server_groups_internal> sysmanagement_shared_server_groups_internal { get; set; }
        public virtual DbSet<syspolicy_conditions_internal> syspolicy_conditions_internal { get; set; }
        public virtual DbSet<syspolicy_configuration_internal> syspolicy_configuration_internal { get; set; }
        public virtual DbSet<syspolicy_management_facets> syspolicy_management_facets { get; set; }
        public virtual DbSet<syspolicy_object_sets_internal> syspolicy_object_sets_internal { get; set; }
        public virtual DbSet<syspolicy_policies_internal> syspolicy_policies_internal { get; set; }
        public virtual DbSet<syspolicy_policy_categories_internal> syspolicy_policy_categories_internal { get; set; }
        public virtual DbSet<syspolicy_policy_category_subscriptions_internal> syspolicy_policy_category_subscriptions_internal { get; set; }
        public virtual DbSet<syspolicy_policy_execution_history_details_internal> syspolicy_policy_execution_history_details_internal { get; set; }
        public virtual DbSet<syspolicy_policy_execution_history_internal> syspolicy_policy_execution_history_internal { get; set; }
        public virtual DbSet<syspolicy_system_health_state_internal> syspolicy_system_health_state_internal { get; set; }
        public virtual DbSet<syspolicy_target_set_levels_internal> syspolicy_target_set_levels_internal { get; set; }
        public virtual DbSet<syspolicy_target_sets_internal> syspolicy_target_sets_internal { get; set; }
        public virtual DbSet<sysschedules> sysschedules { get; set; }
        public virtual DbSet<syssessions> syssessions { get; set; }
        public virtual DbSet<sysssislog> sysssislog { get; set; }
        public virtual DbSet<sysssispackagefolders> sysssispackagefolders { get; set; }
        public virtual DbSet<sysssispackages> sysssispackages { get; set; }
        public virtual DbSet<sysutility_mi_configuration_internal> sysutility_mi_configuration_internal { get; set; }
        public virtual DbSet<sysutility_mi_dac_execution_statistics_internal> sysutility_mi_dac_execution_statistics_internal { get; set; }
        public virtual DbSet<sysutility_mi_session_statistics_internal> sysutility_mi_session_statistics_internal { get; set; }
        public virtual DbSet<sysutility_mi_smo_objects_to_collect_internal> sysutility_mi_smo_objects_to_collect_internal { get; set; }
        public virtual DbSet<sysutility_mi_smo_properties_to_collect_internal> sysutility_mi_smo_properties_to_collect_internal { get; set; }
        public virtual DbSet<sysutility_ucp_computer_cpu_health_internal> sysutility_ucp_computer_cpu_health_internal { get; set; }
        public virtual DbSet<sysutility_ucp_configuration_internal> sysutility_ucp_configuration_internal { get; set; }
        public virtual DbSet<sysutility_ucp_dac_file_space_health_internal> sysutility_ucp_dac_file_space_health_internal { get; set; }
        public virtual DbSet<sysutility_ucp_dac_health_internal> sysutility_ucp_dac_health_internal { get; set; }
        public virtual DbSet<sysutility_ucp_filegroups_with_policy_violations_internal> sysutility_ucp_filegroups_with_policy_violations_internal { get; set; }
        public virtual DbSet<sysutility_ucp_health_policies_internal> sysutility_ucp_health_policies_internal { get; set; }
        public virtual DbSet<sysutility_ucp_managed_instances_internal> sysutility_ucp_managed_instances_internal { get; set; }
        public virtual DbSet<sysutility_ucp_mi_database_health_internal> sysutility_ucp_mi_database_health_internal { get; set; }
        public virtual DbSet<sysutility_ucp_mi_file_space_health_internal> sysutility_ucp_mi_file_space_health_internal { get; set; }
        public virtual DbSet<sysutility_ucp_mi_health_internal> sysutility_ucp_mi_health_internal { get; set; }
        public virtual DbSet<sysutility_ucp_mi_volume_space_health_internal> sysutility_ucp_mi_volume_space_health_internal { get; set; }
        public virtual DbSet<sysutility_ucp_policy_check_conditions_internal> sysutility_ucp_policy_check_conditions_internal { get; set; }
        public virtual DbSet<sysutility_ucp_policy_target_conditions_internal> sysutility_ucp_policy_target_conditions_internal { get; set; }
        public virtual DbSet<sysutility_ucp_policy_violations_internal> sysutility_ucp_policy_violations_internal { get; set; }
        public virtual DbSet<sysutility_ucp_processing_state_internal> sysutility_ucp_processing_state_internal { get; set; }
        public virtual DbSet<sysutility_ucp_supported_object_types_internal> sysutility_ucp_supported_object_types_internal { get; set; }
        public virtual DbSet<log_shipping_monitor_error_detail> log_shipping_monitor_error_detail { get; set; }
        public virtual DbSet<log_shipping_monitor_history_detail> log_shipping_monitor_history_detail { get; set; }
        public virtual DbSet<log_shipping_secondaries> log_shipping_secondaries { get; set; }
        public virtual DbSet<logmarkhistory> logmarkhistory { get; set; }
        public virtual DbSet<msdb_version> msdb_version { get; set; }
        public virtual DbSet<restorefile> restorefile { get; set; }
        public virtual DbSet<restorefilegroup> restorefilegroup { get; set; }
        public virtual DbSet<sqlagent_info> sqlagent_info { get; set; }
        public virtual DbSet<suspect_pages> suspect_pages { get; set; }
        public virtual DbSet<sysalerts> sysalerts { get; set; }
        public virtual DbSet<syscategories> syscategories { get; set; }
        public virtual DbSet<syscollector_tsql_query_collector> syscollector_tsql_query_collector { get; set; }
        public virtual DbSet<sysdbmaintplan_databases> sysdbmaintplan_databases { get; set; }
        public virtual DbSet<sysdbmaintplan_history> sysdbmaintplan_history { get; set; }
        public virtual DbSet<sysdbmaintplan_jobs> sysdbmaintplan_jobs { get; set; }
        public virtual DbSet<sysdownloadlist> sysdownloadlist { get; set; }
        public virtual DbSet<sysjobactivity> sysjobactivity { get; set; }
        public virtual DbSet<sysjobhistory> sysjobhistory { get; set; }
        public virtual DbSet<sysjobs> sysjobs { get; set; }
        public virtual DbSet<sysjobschedules> sysjobschedules { get; set; }
        public virtual DbSet<sysjobservers> sysjobservers { get; set; }
        public virtual DbSet<sysjobsteps> sysjobsteps { get; set; }
        public virtual DbSet<sysmail_attachments> sysmail_attachments { get; set; }
        public virtual DbSet<sysmaintplan_logdetail> sysmaintplan_logdetail { get; set; }
        public virtual DbSet<sysnotifications> sysnotifications { get; set; }
        public virtual DbSet<sysoperators> sysoperators { get; set; }
        public virtual DbSet<sysoriginatingservers> sysoriginatingservers { get; set; }
        public virtual DbSet<syspolicy_facet_events> syspolicy_facet_events { get; set; }
        public virtual DbSet<sysproxies> sysproxies { get; set; }
        public virtual DbSet<sysproxylogin> sysproxylogin { get; set; }
        public virtual DbSet<sysproxysubsystem> sysproxysubsystem { get; set; }
        public virtual DbSet<syssubsystems> syssubsystems { get; set; }
        public virtual DbSet<systargetservergroupmembers> systargetservergroupmembers { get; set; }
        public virtual DbSet<systargetservergroups> systargetservergroups { get; set; }
        public virtual DbSet<systargetservers> systargetservers { get; set; }
        public virtual DbSet<systaskids> systaskids { get; set; }
        public virtual DbSet<sysutility_mi_cpu_stage_internal> sysutility_mi_cpu_stage_internal { get; set; }
        public virtual DbSet<sysutility_mi_smo_stage_internal> sysutility_mi_smo_stage_internal { get; set; }
        public virtual DbSet<sysutility_mi_volumes_stage_internal> sysutility_mi_volumes_stage_internal { get; set; }
        public virtual DbSet<sysutility_ucp_aggregated_dac_health_internal> sysutility_ucp_aggregated_dac_health_internal { get; set; }
        public virtual DbSet<sysutility_ucp_aggregated_mi_health_internal> sysutility_ucp_aggregated_mi_health_internal { get; set; }
        public virtual DbSet<sysutility_ucp_computers_stub> sysutility_ucp_computers_stub { get; set; }
        public virtual DbSet<sysutility_ucp_cpu_utilization_stub> sysutility_ucp_cpu_utilization_stub { get; set; }
        public virtual DbSet<sysutility_ucp_dacs_stub> sysutility_ucp_dacs_stub { get; set; }
        public virtual DbSet<sysutility_ucp_databases_stub> sysutility_ucp_databases_stub { get; set; }
        public virtual DbSet<sysutility_ucp_datafiles_stub> sysutility_ucp_datafiles_stub { get; set; }
        public virtual DbSet<sysutility_ucp_filegroups_stub> sysutility_ucp_filegroups_stub { get; set; }
        public virtual DbSet<sysutility_ucp_logfiles_stub> sysutility_ucp_logfiles_stub { get; set; }
        public virtual DbSet<sysutility_ucp_space_utilization_stub> sysutility_ucp_space_utilization_stub { get; set; }
        public virtual DbSet<sysutility_ucp_volumes_stub> sysutility_ucp_volumes_stub { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<backupfile>()
                .Property(e => e.file_number)
                .HasPrecision(10, 0);

            modelBuilder.Entity<backupfile>()
                .Property(e => e.backed_up_page_count)
                .HasPrecision(10, 0);

            modelBuilder.Entity<backupfile>()
                .Property(e => e.file_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<backupfile>()
                .Property(e => e.source_file_block_size)
                .HasPrecision(10, 0);

            modelBuilder.Entity<backupfile>()
                .Property(e => e.file_size)
                .HasPrecision(20, 0);

            modelBuilder.Entity<backupfile>()
                .Property(e => e.create_lsn)
                .HasPrecision(25, 0);

            modelBuilder.Entity<backupfile>()
                .Property(e => e.drop_lsn)
                .HasPrecision(25, 0);

            modelBuilder.Entity<backupfile>()
                .Property(e => e.read_only_lsn)
                .HasPrecision(25, 0);

            modelBuilder.Entity<backupfile>()
                .Property(e => e.read_write_lsn)
                .HasPrecision(25, 0);

            modelBuilder.Entity<backupfile>()
                .Property(e => e.differential_base_lsn)
                .HasPrecision(25, 0);

            modelBuilder.Entity<backupfile>()
                .Property(e => e.backup_size)
                .HasPrecision(20, 0);

            modelBuilder.Entity<backupfilegroup>()
                .Property(e => e.type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<backupmediaset>()
                .HasMany(e => e.backupmediafamily)
                .WithRequired(e => e.backupmediaset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<backupmediaset>()
                .HasMany(e => e.backupset)
                .WithRequired(e => e.backupmediaset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<backupset>()
                .Property(e => e.first_lsn)
                .HasPrecision(25, 0);

            modelBuilder.Entity<backupset>()
                .Property(e => e.last_lsn)
                .HasPrecision(25, 0);

            modelBuilder.Entity<backupset>()
                .Property(e => e.checkpoint_lsn)
                .HasPrecision(25, 0);

            modelBuilder.Entity<backupset>()
                .Property(e => e.database_backup_lsn)
                .HasPrecision(25, 0);

            modelBuilder.Entity<backupset>()
                .Property(e => e.type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<backupset>()
                .Property(e => e.backup_size)
                .HasPrecision(20, 0);

            modelBuilder.Entity<backupset>()
                .Property(e => e.fork_point_lsn)
                .HasPrecision(25, 0);

            modelBuilder.Entity<backupset>()
                .Property(e => e.differential_base_lsn)
                .HasPrecision(25, 0);

            modelBuilder.Entity<backupset>()
                .Property(e => e.compressed_backup_size)
                .HasPrecision(20, 0);

            modelBuilder.Entity<backupset>()
                .HasMany(e => e.backupfile)
                .WithRequired(e => e.backupset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<backupset>()
                .HasMany(e => e.backupfilegroup)
                .WithRequired(e => e.backupset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<backupset>()
                .HasMany(e => e.restorehistory)
                .WithRequired(e => e.backupset)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSdbms>()
                .HasMany(e => e.MSdbms_datatype)
                .WithRequired(e => e.MSdbms)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSdbms>()
                .HasMany(e => e.MSdbms_map)
                .WithRequired(e => e.MSdbms)
                .HasForeignKey(e => e.dest_dbms_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSdbms>()
                .HasMany(e => e.MSdbms_map1)
                .WithRequired(e => e.MSdbms1)
                .HasForeignKey(e => e.src_dbms_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSdbms_datatype>()
                .HasMany(e => e.MSdbms_datatype_mapping)
                .WithRequired(e => e.MSdbms_datatype)
                .HasForeignKey(e => e.dest_datatype_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSdbms_datatype>()
                .HasMany(e => e.MSdbms_map)
                .WithRequired(e => e.MSdbms_datatype)
                .HasForeignKey(e => e.src_datatype_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MSdbms_datatype_mapping>()
                .HasMany(e => e.MSdbms_map1)
                .WithOptional(e => e.MSdbms_datatype_mapping1)
                .HasForeignKey(e => e.default_datatype_mapping_id);

            modelBuilder.Entity<MSdbms_map>()
                .HasMany(e => e.MSdbms_datatype_mapping)
                .WithRequired(e => e.MSdbms_map)
                .HasForeignKey(e => e.map_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<restorehistory>()
                .Property(e => e.restore_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<restorehistory>()
                .HasOptional(e => e.restorefile)
                .WithRequired(e => e.restorehistory);

            modelBuilder.Entity<restorehistory>()
                .HasOptional(e => e.restorefilegroup)
                .WithRequired(e => e.restorehistory);

            modelBuilder.Entity<syscollector_collection_items_internal>()
                .HasMany(e => e.syscollector_tsql_query_collector)
                .WithRequired(e => e.syscollector_collection_items_internal)
                .HasForeignKey(e => new { e.collection_set_id, e.collection_item_id });

            modelBuilder.Entity<syscollector_collection_sets_internal>()
                .HasMany(e => e.syscollector_execution_log_internal)
                .WithRequired(e => e.syscollector_collection_sets_internal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sysdac_history_internal>()
                .Property(e => e.action_type_name)
                .IsUnicode(false);

            modelBuilder.Entity<sysdac_history_internal>()
                .Property(e => e.dac_object_type_name)
                .IsUnicode(false);

            modelBuilder.Entity<sysdac_history_internal>()
                .Property(e => e.action_status_name)
                .IsUnicode(false);

            modelBuilder.Entity<sysdac_history_internal>()
                .Property(e => e.comments)
                .IsUnicode(false);

            modelBuilder.Entity<sysdbmaintplans>()
                .HasMany(e => e.sysdbmaintplan_jobs)
                .WithRequired(e => e.sysdbmaintplans)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sysdbmaintplans>()
                .HasMany(e => e.sysdbmaintplan_databases)
                .WithRequired(e => e.sysdbmaintplans)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sysmail_mailitems>()
                .Property(e => e.recipients)
                .IsUnicode(false);

            modelBuilder.Entity<sysmail_mailitems>()
                .Property(e => e.copy_recipients)
                .IsUnicode(false);

            modelBuilder.Entity<sysmail_mailitems>()
                .Property(e => e.blind_copy_recipients)
                .IsUnicode(false);

            modelBuilder.Entity<sysmail_mailitems>()
                .Property(e => e.from_address)
                .IsUnicode(false);

            modelBuilder.Entity<sysmail_mailitems>()
                .Property(e => e.reply_to)
                .IsUnicode(false);

            modelBuilder.Entity<sysmail_mailitems>()
                .Property(e => e.body_format)
                .IsUnicode(false);

            modelBuilder.Entity<sysmail_mailitems>()
                .Property(e => e.importance)
                .IsUnicode(false);

            modelBuilder.Entity<sysmail_mailitems>()
                .Property(e => e.sensitivity)
                .IsUnicode(false);

            modelBuilder.Entity<sysmail_mailitems>()
                .Property(e => e.attachment_encoding)
                .IsUnicode(false);

            modelBuilder.Entity<sysmail_mailitems>()
                .Property(e => e.query_result_separator)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<sysmail_servertype>()
                .HasMany(e => e.sysmail_server)
                .WithRequired(e => e.sysmail_servertype)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sysmanagement_shared_server_groups_internal>()
                .HasMany(e => e.sysmanagement_shared_registered_servers_internal)
                .WithOptional(e => e.sysmanagement_shared_server_groups_internal)
                .WillCascadeOnDelete();

            modelBuilder.Entity<syspolicy_conditions_internal>()
                .HasMany(e => e.syspolicy_policies_internal)
                .WithRequired(e => e.syspolicy_conditions_internal)
                .HasForeignKey(e => e.condition_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<syspolicy_conditions_internal>()
                .HasMany(e => e.syspolicy_policies_internal1)
                .WithOptional(e => e.syspolicy_conditions_internal1)
                .HasForeignKey(e => e.root_condition_id);

            modelBuilder.Entity<syspolicy_management_facets>()
                .HasMany(e => e.syspolicy_conditions_internal)
                .WithOptional(e => e.syspolicy_management_facets)
                .HasForeignKey(e => e.facet_id);

            modelBuilder.Entity<syspolicy_management_facets>()
                .HasMany(e => e.syspolicy_facet_events)
                .WithRequired(e => e.syspolicy_management_facets)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<syspolicy_management_facets>()
                .HasMany(e => e.syspolicy_object_sets_internal)
                .WithOptional(e => e.syspolicy_management_facets)
                .HasForeignKey(e => e.facet_id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<syspolicy_policies_internal>()
                .HasMany(e => e.syspolicy_system_health_state_internal)
                .WithRequired(e => e.syspolicy_policies_internal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<syspolicy_policies_internal>()
                .HasMany(e => e.syspolicy_policy_execution_history_internal)
                .WithRequired(e => e.syspolicy_policies_internal)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<syssessions>()
                .HasMany(e => e.sysjobactivity)
                .WithRequired(e => e.syssessions)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sysssispackages>()
                .HasMany(e => e.syscollector_collector_types_internal)
                .WithRequired(e => e.sysssispackages)
                .HasForeignKey(e => new { e.collection_package_name, e.collection_package_folderid })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sysssispackages>()
                .HasMany(e => e.syscollector_collector_types_internal1)
                .WithRequired(e => e.sysssispackages1)
                .HasForeignKey(e => new { e.upload_package_name, e.upload_package_folderid })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<logmarkhistory>()
                .Property(e => e.lsn)
                .HasPrecision(25, 0);

            modelBuilder.Entity<restorefile>()
                .Property(e => e.file_number)
                .HasPrecision(10, 0);

            modelBuilder.Entity<sysutility_mi_cpu_stage_internal>()
                .Property(e => e.cpu_family_id)
                .HasPrecision(5, 0);

            modelBuilder.Entity<sysutility_mi_cpu_stage_internal>()
                .Property(e => e.cpu_architecture_id)
                .HasPrecision(5, 0);

            modelBuilder.Entity<sysutility_mi_cpu_stage_internal>()
                .Property(e => e.cpu_max_clock_speed)
                .HasPrecision(10, 0);

            modelBuilder.Entity<sysutility_mi_cpu_stage_internal>()
                .Property(e => e.cpu_clock_speed)
                .HasPrecision(10, 0);

            modelBuilder.Entity<sysutility_mi_cpu_stage_internal>()
                .Property(e => e.l2_cache_size)
                .HasPrecision(10, 0);

            modelBuilder.Entity<sysutility_mi_cpu_stage_internal>()
                .Property(e => e.l3_cache_size)
                .HasPrecision(10, 0);

            modelBuilder.Entity<sysutility_mi_cpu_stage_internal>()
                .Property(e => e.instance_processor_usage_start_ticks)
                .HasPrecision(20, 0);

            modelBuilder.Entity<sysutility_mi_cpu_stage_internal>()
                .Property(e => e.instance_collect_time_start_ticks)
                .HasPrecision(20, 0);

            modelBuilder.Entity<sysutility_mi_cpu_stage_internal>()
                .Property(e => e.computer_processor_idle_start_ticks)
                .HasPrecision(20, 0);

            modelBuilder.Entity<sysutility_mi_cpu_stage_internal>()
                .Property(e => e.computer_collect_time_start_ticks)
                .HasPrecision(20, 0);

            modelBuilder.Entity<sysutility_mi_cpu_stage_internal>()
                .Property(e => e.instance_processor_usage_end_ticks)
                .HasPrecision(20, 0);

            modelBuilder.Entity<sysutility_mi_cpu_stage_internal>()
                .Property(e => e.instance_collect_time_end_ticks)
                .HasPrecision(20, 0);

            modelBuilder.Entity<sysutility_mi_cpu_stage_internal>()
                .Property(e => e.computer_processor_idle_end_ticks)
                .HasPrecision(20, 0);

            modelBuilder.Entity<sysutility_mi_cpu_stage_internal>()
                .Property(e => e.computer_collect_time_end_ticks)
                .HasPrecision(20, 0);

            modelBuilder.Entity<sysutility_mi_volumes_stage_internal>()
                .Property(e => e.capacity_mb)
                .HasPrecision(20, 0);

            modelBuilder.Entity<sysutility_mi_volumes_stage_internal>()
                .Property(e => e.free_space_mb)
                .HasPrecision(20, 0);

            modelBuilder.Entity<sysutility_ucp_computers_stub>()
                .Property(e => e.cpu_max_clock_speed)
                .HasPrecision(10, 0);

            modelBuilder.Entity<sysutility_ucp_computers_stub>()
                .Property(e => e.cpu_clock_speed)
                .HasPrecision(10, 0);

            modelBuilder.Entity<sysutility_ucp_computers_stub>()
                .Property(e => e.l2_cache_size)
                .HasPrecision(10, 0);

            modelBuilder.Entity<sysutility_ucp_computers_stub>()
                .Property(e => e.l3_cache_size)
                .HasPrecision(10, 0);
        }
    }
}

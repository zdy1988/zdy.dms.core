﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using ZDY.DMS.DataPermission;

namespace ZDY.DMS.Models
{
    [Table("Work_Flow")]
    public class WorkFlow : BaseEntity, ICompanyEntity<Guid>
    {
        /// <summary>
        /// 关联的表单ID
        /// </summary>
        public Guid FormId { get; set; } = default;
        /// <summary>
        /// 流程名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 流程分类
        /// </summary>
        public int Type { get; set; }
        /// <summary>
        /// 管理人员
        /// </summary>
        public string Manager { get; set; }
        /// <summary>
        /// 实例管理人员
        /// </summary>
        public string InstanceManager { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public Guid CreaterId { get; set; }
        /// <summary>
        /// 设计时
        /// </summary>
        public string DesignJson { get; set; }
        /// <summary>
        /// 运行时
        /// </summary>
        public string RunJson { get; set; }
        /// <summary>
        /// 安装日期
        /// </summary>
        public Nullable<DateTime> InstallTime { get; set; }
        /// <summary>
        /// 安装人员
        /// </summary>
        public Guid InstallerId { get; set; } = default(Guid);
        /// <summary>
        /// 状态 1:设计中 2:已安装 3:已卸载 4:已删除
        /// </summary>
        public int State { get; set; } = 0;
        /// <summary>
        /// 是否删除已完成
        /// </summary>
        public bool IsRemoveCompleted { get; set; } = false;
        /// <summary>
        /// 备注
        /// </summary>
        public string Note { get; set; }
        /// <summary>
        /// 是否禁用
        /// </summary>
        public bool IsDisabled { get; set; } = false;
        /// <summary>
        /// 公司ID
        /// </summary>
        public Guid CompanyId { get; set; } 
    }
}

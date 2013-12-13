﻿//------------------------------------------------------------------------------
// <auto-generated>
// 此代码由Codesmith工具生成。
// 此文件的更改可能会导致不正确的行为，如果
// 重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using ProtoBuf;
using ZyGames.Framework.Common;
using ZyGames.Framework.Collection;
using ZyGames.Framework.Model;


namespace ZyGames.Doudizhu.Model
{
    /// <summary>
    /// 转盘奖励配置表
    /// </summary>
    /// <![CDATA[
    /// @periodTime:设置生存周期(秒)
    /// @personalName: 映射UserId对应的字段名,默认为"UserId"
    /// ]]>
    /// </remarks>
    [Serializable, ProtoContract]
    [EntityTable(AccessLevel.ReadOnly, DbConfig.Config, "DialInfo")]
    public class DialInfo : ShareEntity
    {

        /// <summary>
        /// </summary>
        public DialInfo()
            : base(AccessLevel.ReadOnly)
        {
            
        }        
        /// <summary>
        /// </summary>
        public DialInfo(int iD)
            : this()
        {
            _iD = iD;
        }

        #region 自动生成属性
        private int _iD;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(1)]
        [EntityField("ID", IsKey = true)]
        public int ID
        {
            get
            {
                return _iD;
            } 
            
        }
        private int _gameCoin;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(2)]
        [EntityField("GameCoin")]
        public int GameCoin
        {
            get
            {
                return _gameCoin;
            } 
            
        }
        private string _headID;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(3)]
        [EntityField("HeadID")]
        public string HeadID
        {
            get
            {
                return _headID;
            } 
            
        }
        private decimal _probability;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(4)]
        [EntityField("Probability")]
        public decimal Probability
        {
            get
            {
                return _probability;
            } 
            
        }
        private string _itemDesc;
        /// <summary>
        /// 
        /// </summary>        
        [ProtoMember(5)]
        [EntityField("ItemDesc")]
        public string ItemDesc
        {
            get
            {
                return _itemDesc;
            } 
            
        }
    
        protected override object this[string index]
		{
			get
			{
                #region
				switch (index)
				{
                    case "ID": return _iD;
                    case "GameCoin": return _gameCoin;
                    case "HeadID": return _headID;
                    case "Probability": return _probability;
                    case "ItemDesc": return _itemDesc;
					default: throw new ArgumentException(string.Format("DialInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
			set
			{
                #region
				switch (index)
				{
                    case "ID": 
                        _iD = value.ToInt();
                        break; 
                    case "GameCoin": 
                        _gameCoin = value.ToInt();
                        break; 
                    case "HeadID": 
                        _headID = value.ToNotNullString();
                        break; 
                    case "Probability": 
                        _probability = value.ToDecimal();
                        break; 
                    case "ItemDesc": 
                        _itemDesc = value.ToNotNullString();
                        break; 
					default: throw new ArgumentException(string.Format("DialInfo index[{0}] isn't exist.", index));
				}
                #endregion
			}
		}
        
        #endregion
        

	}
}
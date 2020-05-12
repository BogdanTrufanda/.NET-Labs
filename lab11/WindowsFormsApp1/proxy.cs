﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace PostComment
{
    [DataContract(IsReference = true)]
    public partial class CommentDTO
    {
        [DataMember]
        public int CommentId { get; set; }
        [DataMember]
        public string CommentText { get; set; }
        [DataMember]
        public int PostId { get; set; }
        [DataMember]
        public int PostPostId { get; set; }
        [DataMember]
        public virtual PostDTO Post { get; set; }
    }

    [DataContract]
    public partial class PostDTO
    {
        public PostDTO()
        {
            this.Comments = new List<CommentDTO>(); //new HashSet<Comment>();
        }
        [DataMember]
        public int PostId { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public virtual List<CommentDTO> Comments { get; set; }
    }









    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Post", Namespace="http://schemas.datacontract.org/2004/07/PostComment", IsReference=true)]
    public partial class Post : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private PostComment.Comment[] CommentsField;
        
        private string DateField;
        
        private string DescriptionField;
        
        private string DomainField;
        
        private int PostIdField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PostComment.Comment[] Comments
        {
            get
            {
                return this.CommentsField;
            }
            set
            {
                this.CommentsField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Date
        {
            get
            {
                return this.DateField;
            }
            set
            {
                this.DateField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Domain
        {
            get
            {
                return this.DomainField;
            }
            set
            {
                this.DomainField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PostId
        {
            get
            {
                return this.PostIdField;
            }
            set
            {
                this.PostIdField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Comment", Namespace="http://schemas.datacontract.org/2004/07/PostComment", IsReference=true)]
    public partial class Comment : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int CommentIdField;
        
        private PostComment.Post PostField;
        
        private int PostPostIdField;
        
        private string TextField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CommentId
        {
            get
            {
                return this.CommentIdField;
            }
            set
            {
                this.CommentIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PostComment.Post Post
        {
            get
            {
                return this.PostField;
            }
            set
            {
                this.PostField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PostPostId
        {
            get
            {
                return this.PostPostIdField;
            }
            set
            {
                this.PostPostIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text
        {
            get
            {
                return this.TextField;
            }
            set
            {
                this.TextField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IPostComment")]
public interface IPostComment
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/AddPost", ReplyAction="http://tempuri.org/InterfacePost/AddPostResponse")]
    bool AddPost(PostComment.Post post);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/AddPost", ReplyAction="http://tempuri.org/InterfacePost/AddPostResponse")]
    System.Threading.Tasks.Task<bool> AddPostAsync(PostComment.Post post);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/UpdatePost", ReplyAction="http://tempuri.org/InterfacePost/UpdatePostResponse")]
    PostComment.Post UpdatePost(PostComment.Post post);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/UpdatePost", ReplyAction="http://tempuri.org/InterfacePost/UpdatePostResponse")]
    System.Threading.Tasks.Task<PostComment.Post> UpdatePostAsync(PostComment.Post post);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/DeletePost", ReplyAction="http://tempuri.org/InterfacePost/DeletePostResponse")]
    int DeletePost(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/DeletePost", ReplyAction="http://tempuri.org/InterfacePost/DeletePostResponse")]
    System.Threading.Tasks.Task<int> DeletePostAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/GetPostById", ReplyAction="http://tempuri.org/InterfacePost/GetPostByIdResponse")]
    PostComment.Post GetPostById(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/GetPostById", ReplyAction="http://tempuri.org/InterfacePost/GetPostByIdResponse")]
    System.Threading.Tasks.Task<PostComment.Post> GetPostByIdAsync(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/GetPosts", ReplyAction="http://tempuri.org/InterfacePost/GetPostsResponse")]
    PostComment.Post[] GetPosts();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfacePost/GetPosts", ReplyAction="http://tempuri.org/InterfacePost/GetPostsResponse")]
    System.Threading.Tasks.Task<PostComment.Post[]> GetPostsAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceComment/AddComment", ReplyAction="http://tempuri.org/InterfaceComment/AddCommentResponse")]
    bool AddComment(PostComment.Comment comment);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceComment/AddComment", ReplyAction="http://tempuri.org/InterfaceComment/AddCommentResponse")]
    System.Threading.Tasks.Task<bool> AddCommentAsync(PostComment.Comment comment);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceComment/UpdateComment", ReplyAction="http://tempuri.org/InterfaceComment/UpdateCommentResponse")]
    PostComment.Comment UpdateComment(PostComment.Comment newComment);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceComment/UpdateComment", ReplyAction="http://tempuri.org/InterfaceComment/UpdateCommentResponse")]
    System.Threading.Tasks.Task<PostComment.Comment> UpdateCommentAsync(PostComment.Comment newComment);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceComment/GetCommentById", ReplyAction="http://tempuri.org/InterfaceComment/GetCommentByIdResponse")]
    PostComment.Comment GetCommentById(int id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceComment/GetCommentById", ReplyAction="http://tempuri.org/InterfaceComment/GetCommentByIdResponse")]
    System.Threading.Tasks.Task<PostComment.Comment> GetCommentByIdAsync(int id);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IPostCommentChannel : IPostComment, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class PostCommentClient : System.ServiceModel.ClientBase<IPostComment>, IPostComment
{
    
    public PostCommentClient()
    {
    }
    
    public PostCommentClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public PostCommentClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public PostCommentClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public PostCommentClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public bool AddPost(PostComment.Post post)
    {
        return base.Channel.AddPost(post);
    }
    
    public System.Threading.Tasks.Task<bool> AddPostAsync(PostComment.Post post)
    {
        return base.Channel.AddPostAsync(post);
    }
    
    public PostComment.Post UpdatePost(PostComment.Post post)
    {
        return base.Channel.UpdatePost(post);
    }
    
    public System.Threading.Tasks.Task<PostComment.Post> UpdatePostAsync(PostComment.Post post)
    {
        return base.Channel.UpdatePostAsync(post);
    }
    
    public int DeletePost(int id)
    {
        return base.Channel.DeletePost(id);
    }
    
    public System.Threading.Tasks.Task<int> DeletePostAsync(int id)
    {
        return base.Channel.DeletePostAsync(id);
    }
    
    public PostComment.Post GetPostById(int id)
    {
        return base.Channel.GetPostById(id);
    }
    
    public System.Threading.Tasks.Task<PostComment.Post> GetPostByIdAsync(int id)
    {
        return base.Channel.GetPostByIdAsync(id);
    }
    
    public PostComment.Post[] GetPosts()
    {
        return base.Channel.GetPosts();
    }
    
    public System.Threading.Tasks.Task<PostComment.Post[]> GetPostsAsync()
    {
        return base.Channel.GetPostsAsync();
    }
    
    public bool AddComment(PostComment.Comment comment)
    {
        return base.Channel.AddComment(comment);
    }
    
    public System.Threading.Tasks.Task<bool> AddCommentAsync(PostComment.Comment comment)
    {
        return base.Channel.AddCommentAsync(comment);
    }
    
    public PostComment.Comment UpdateComment(PostComment.Comment newComment)
    {
        return base.Channel.UpdateComment(newComment);
    }
    
    public System.Threading.Tasks.Task<PostComment.Comment> UpdateCommentAsync(PostComment.Comment newComment)
    {
        return base.Channel.UpdateCommentAsync(newComment);
    }
    
    public PostComment.Comment GetCommentById(int id)
    {
        return base.Channel.GetCommentById(id);
    }
    
    public System.Threading.Tasks.Task<PostComment.Comment> GetCommentByIdAsync(int id)
    {
        return base.Channel.GetCommentByIdAsync(id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salesforce.Tooling.Models
{
    public class Completions
    {
        public PublicDeclarations publicDeclarations { get; set; }
    }

    public class PublicDeclarations
    {
        public Apex Apex { get; set; }
        public ApexPages ApexPages { get; set; }
        public Approval Approval { get; set; }
        public Canvas Canvas { get; set; }
        public ChatterAnswers ChatterAnswers { get; set; }
        public ConnectApi ConnectApi { get; set; }
        public Database Database { get; set; }
        public Flow Flow { get; set; }
        public KbManagement KbManagement { get; set; }
        public LiveAgent LiveAgent { get; set; }
        public Messaging Messaging { get; set; }
        public Process Process { get; set; }
        public QuickAction QuickAction { get; set; }
        public Schema Schema { get; set; }
        public Site Site { get; set; }
        public Social Social { get; set; }
        public Support Support { get; set; }
        public System System { get; set; }
        public TxnSecurity TxnSecurity { get; set; }
        public UIGuide UIGuide { get; set; }
        public Applauncher applauncher { get; set; }
        public Dom dom { get; set; }
        public Predictive predictive { get; set; }
        public Reports reports { get; set; }
        public Workflow workflow { get; set; }
    }

    public class Parameter
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor
    {
        public string name { get; set; }
        public IList<Parameter> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class EmptyStackException
    {
        public IList<Constructor> constructors { get; set; }
        public IList<Method> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor2
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter2
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method2
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter2> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Stack
    {
        public IList<Constructor2> constructors { get; set; }
        public IList<Method2> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Apex
    {
        public EmptyStackException EmptyStackException { get; set; }
        public Stack Stack { get; set; }
    }

    public class Parameter3
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor3
    {
        public string name { get; set; }
        public IList<Parameter3> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method3
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Action
    {
        public IList<Constructor3> constructors { get; set; }
        public IList<Method3> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter4
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method4
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter4> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Component
    {
        public IList<object> constructors { get; set; }
        public IList<Method4> methods { get; set; }
        public IList<Property> properties { get; set; }
    }

    public class Parameter5
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method5
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter5> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property2
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ComponentIteration
    {
        public IList<object> constructors { get; set; }
        public IList<Method5> methods { get; set; }
        public IList<Property2> properties { get; set; }
    }

    public class Parameter6
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method6
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter6> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class IdeaStandardController
    {
        public IList<object> constructors { get; set; }
        public IList<Method6> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter7
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method7
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter7> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class IdeaStandardSetController
    {
        public IList<object> constructors { get; set; }
        public IList<Method7> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter8
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor4
    {
        public object name { get; set; }
        public IList<Parameter8> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter9
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method8
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter9> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class KnowledgeArticleVersionStandardController
    {
        public IList<Constructor4> constructors { get; set; }
        public IList<Method8> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter10
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor5
    {
        public object name { get; set; }
        public IList<Parameter10> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method9
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Message
    {
        public IList<Constructor5> constructors { get; set; }
        public IList<Method9> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter11
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method10
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter11> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property3
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Severity
    {
        public IList<object> constructors { get; set; }
        public IList<Method10> methods { get; set; }
        public IList<Property3> properties { get; set; }
    }

    public class Parameter12
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor6
    {
        public object name { get; set; }
        public IList<Parameter12> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter13
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method11
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter13> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class StandardController
    {
        public IList<Constructor6> constructors { get; set; }
        public IList<Method11> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter14
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor7
    {
        public object name { get; set; }
        public IList<Parameter14> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter15
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method12
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter15> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class StandardSetController
    {
        public IList<Constructor7> constructors { get; set; }
        public IList<Method12> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class ApexPages
    {
        public Action Action { get; set; }
        public Component Component { get; set; }
        public ComponentIteration ComponentIteration { get; set; }
        public IdeaStandardController IdeaStandardController { get; set; }
        public IdeaStandardSetController IdeaStandardSetController { get; set; }
        public KnowledgeArticleVersionStandardController KnowledgeArticleVersionStandardController { get; set; }
        public Message Message { get; set; }
        public Severity Severity { get; set; }
        public StandardController StandardController { get; set; }
        public StandardSetController StandardSetController { get; set; }
    }

    public class Parameter16
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method13
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter16> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ProcessRequest
    {
        public IList<object> constructors { get; set; }
        public IList<Method13> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method14
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ProcessResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method14> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor8
    {
        public object name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter17
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method15
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter17> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ProcessSubmitRequest
    {
        public IList<Constructor8> constructors { get; set; }
        public IList<Method15> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor9
    {
        public object name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter18
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method16
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter18> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ProcessWorkitemRequest
    {
        public IList<Constructor9> constructors { get; set; }
        public IList<Method16> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Approval
    {
        public ProcessRequest ProcessRequest { get; set; }
        public ProcessResult ProcessResult { get; set; }
        public ProcessSubmitRequest ProcessSubmitRequest { get; set; }
        public ProcessWorkitemRequest ProcessWorkitemRequest { get; set; }
    }

    public class Parameter19
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method17
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter19> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ApplicationContext
    {
        public IList<object> constructors { get; set; }
        public IList<Method17> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter20
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method18
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter20> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class CanvasLifecycleHandler
    {
        public IList<object> constructors { get; set; }
        public IList<Method18> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter21
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor10
    {
        public string name { get; set; }
        public IList<Parameter21> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method19
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class CanvasRenderException
    {
        public IList<Constructor10> constructors { get; set; }
        public IList<Method19> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter22
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method20
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter22> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property4
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ContextTypeEnum
    {
        public IList<object> constructors { get; set; }
        public IList<Method20> methods { get; set; }
        public IList<Property4> properties { get; set; }
    }

    public class Parameter23
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method21
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter23> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class EnvironmentContext
    {
        public IList<object> constructors { get; set; }
        public IList<Method21> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method22
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class RenderContext
    {
        public IList<object> constructors { get; set; }
        public IList<Method22> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor11
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter24
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method23
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter24> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property5
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Test
    {
        public IList<Constructor11> constructors { get; set; }
        public IList<Method23> methods { get; set; }
        public IList<Property5> properties { get; set; }
    }

    public class Canvas
    {
        public ApplicationContext ApplicationContext { get; set; }
        public CanvasLifecycleHandler CanvasLifecycleHandler { get; set; }
        public CanvasRenderException CanvasRenderException { get; set; }
        public ContextTypeEnum ContextTypeEnum { get; set; }
        public EnvironmentContext EnvironmentContext { get; set; }
        public RenderContext RenderContext { get; set; }
        public Test Test { get; set; }
    }

    public class Parameter25
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method24
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter25> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class AccountCreator
    {
        public IList<object> constructors { get; set; }
        public IList<Method24> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class ChatterAnswers
    {
        public AccountCreator AccountCreator { get; set; }
    }

    public class Parameter26
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method25
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter26> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property6
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class AbstractMessageBody
    {
        public IList<object> constructors { get; set; }
        public IList<Method25> methods { get; set; }
        public IList<Property6> properties { get; set; }
    }

    public class Parameter27
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method26
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter27> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property7
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class AbstractRecommendation
    {
        public IList<object> constructors { get; set; }
        public IList<Method26> methods { get; set; }
        public IList<Property7> properties { get; set; }
    }

    public class Parameter28
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method27
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter28> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property8
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class AbstractRecommendationExplanation
    {
        public IList<object> constructors { get; set; }
        public IList<Method27> methods { get; set; }
        public IList<Property8> properties { get; set; }
    }

    public class Parameter29
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method28
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter29> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property9
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class AbstractRecordField
    {
        public IList<object> constructors { get; set; }
        public IList<Method28> methods { get; set; }
        public IList<Property9> properties { get; set; }
    }

    public class Parameter30
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method29
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter30> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class AbstractRecordView
    {
        public IList<object> constructors { get; set; }
        public IList<Method29> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter31
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method30
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter31> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property10
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Actor
    {
        public IList<object> constructors { get; set; }
        public IList<Method30> methods { get; set; }
        public IList<Property10> properties { get; set; }
    }

    public class Parameter32
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method31
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter32> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property11
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ActorWithId
    {
        public IList<object> constructors { get; set; }
        public IList<Method31> methods { get; set; }
        public IList<Property11> properties { get; set; }
    }

    public class Constructor12
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter33
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method32
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter33> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property12
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Address
    {
        public IList<Constructor12> constructors { get; set; }
        public IList<Method32> methods { get; set; }
        public IList<Property12> properties { get; set; }
    }

    public class Constructor13
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter34
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method33
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter34> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property13
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Announcement
    {
        public IList<Constructor13> constructors { get; set; }
        public IList<Method33> methods { get; set; }
        public IList<Property13> properties { get; set; }
    }

    public class Constructor14
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter35
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method34
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter35> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property14
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class AnnouncementInput
    {
        public IList<Constructor14> constructors { get; set; }
        public IList<Method34> methods { get; set; }
        public IList<Property14> properties { get; set; }
    }

    public class Constructor15
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter36
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method35
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter36> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property15
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class AnnouncementPage
    {
        public IList<Constructor15> constructors { get; set; }
        public IList<Method35> methods { get; set; }
        public IList<Property15> properties { get; set; }
    }

    public class Parameter37
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method36
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter37> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Announcements
    {
        public IList<object> constructors { get; set; }
        public IList<Method36> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor16
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter38
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method37
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter38> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property16
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ApprovalAttachment
    {
        public IList<Constructor16> constructors { get; set; }
        public IList<Method37> methods { get; set; }
        public IList<Property16> properties { get; set; }
    }

    public class Constructor17
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter39
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method38
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter39> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property17
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ApprovalCapability
    {
        public IList<Constructor17> constructors { get; set; }
        public IList<Method38> methods { get; set; }
        public IList<Property17> properties { get; set; }
    }

    public class Constructor18
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter40
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method39
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter40> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property18
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ApprovalPostTemplateField
    {
        public IList<Constructor18> constructors { get; set; }
        public IList<Method39> methods { get; set; }
        public IList<Property18> properties { get; set; }
    }

    public class Constructor19
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter41
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method40
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter41> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property19
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ArticleItem
    {
        public IList<Constructor19> constructors { get; set; }
        public IList<Method40> methods { get; set; }
        public IList<Property19> properties { get; set; }
    }

    public class Constructor20
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter42
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method41
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter42> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class AssociatedActionsCapability
    {
        public IList<Constructor20> constructors { get; set; }
        public IList<Method41> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter43
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method42
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter43> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property20
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class BadgeLimitType
    {
        public IList<object> constructors { get; set; }
        public IList<Method42> methods { get; set; }
        public IList<Property20> properties { get; set; }
    }

    public class Constructor21
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter44
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method43
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter44> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property21
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class BannerCapability
    {
        public IList<Constructor21> constructors { get; set; }
        public IList<Method43> methods { get; set; }
        public IList<Property21> properties { get; set; }
    }

    public class Parameter45
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method44
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter45> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property22
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class BannerStyle
    {
        public IList<object> constructors { get; set; }
        public IList<Method44> methods { get; set; }
        public IList<Property22> properties { get; set; }
    }

    public class Constructor22
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter46
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method45
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter46> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property23
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class BasicTemplateAttachment
    {
        public IList<Constructor22> constructors { get; set; }
        public IList<Method45> methods { get; set; }
        public IList<Property23> properties { get; set; }
    }

    public class Parameter47
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor23
    {
        public string name { get; set; }
        public IList<Parameter47> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method46
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class BatchInput
    {
        public IList<Constructor23> constructors { get; set; }
        public IList<Method46> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter48
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor24
    {
        public string name { get; set; }
        public IList<Parameter48> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method47
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property24
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class BatchResult
    {
        public IList<Constructor24> constructors { get; set; }
        public IList<Method47> methods { get; set; }
        public IList<Property24> properties { get; set; }
    }

    public class Parameter49
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor25
    {
        public string name { get; set; }
        public IList<Parameter49> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method48
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class BinaryInput
    {
        public IList<Constructor25> constructors { get; set; }
        public IList<Method48> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor26
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter50
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method49
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter50> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class BlankRecordField
    {
        public IList<Constructor26> constructors { get; set; }
        public IList<Method49> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor27
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter51
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method50
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter51> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property25
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class BookmarksCapability
    {
        public IList<Constructor27> constructors { get; set; }
        public IList<Method50> methods { get; set; }
        public IList<Property25> properties { get; set; }
    }

    public class Constructor28
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter52
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method51
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter52> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property26
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class BookmarksCapabilityInput
    {
        public IList<Constructor28> constructors { get; set; }
        public IList<Method51> methods { get; set; }
        public IList<Property26> properties { get; set; }
    }

    public class Parameter53
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method52
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter53> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property27
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class BundleCapability
    {
        public IList<object> constructors { get; set; }
        public IList<Method52> methods { get; set; }
        public IList<Property27> properties { get; set; }
    }

    public class Parameter54
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method53
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter54> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property28
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class BundleType
    {
        public IList<object> constructors { get; set; }
        public IList<Method53> methods { get; set; }
        public IList<Property28> properties { get; set; }
    }

    public class Constructor29
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter55
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method54
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter55> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property29
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CanvasAttachmentInput
    {
        public IList<Constructor29> constructors { get; set; }
        public IList<Method54> methods { get; set; }
        public IList<Property29> properties { get; set; }
    }

    public class Constructor30
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter56
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method55
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter56> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property30
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CanvasCapability
    {
        public IList<Constructor30> constructors { get; set; }
        public IList<Method55> methods { get; set; }
        public IList<Property30> properties { get; set; }
    }

    public class Constructor31
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter57
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method56
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter57> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property31
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CanvasCapabilityInput
    {
        public IList<Constructor31> constructors { get; set; }
        public IList<Method56> methods { get; set; }
        public IList<Property31> properties { get; set; }
    }

    public class Constructor32
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter58
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method57
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter58> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property32
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CanvasTemplateAttachment
    {
        public IList<Constructor32> constructors { get; set; }
        public IList<Method57> methods { get; set; }
        public IList<Property32> properties { get; set; }
    }

    public class Parameter59
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method58
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter59> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property33
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CaseActorType
    {
        public IList<object> constructors { get; set; }
        public IList<Method58> methods { get; set; }
        public IList<Property33> properties { get; set; }
    }

    public class Constructor33
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter60
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method59
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter60> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property34
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CaseComment
    {
        public IList<Constructor33> constructors { get; set; }
        public IList<Method59> methods { get; set; }
        public IList<Property34> properties { get; set; }
    }

    public class Constructor34
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter61
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method60
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter61> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property35
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CaseCommentCapability
    {
        public IList<Constructor34> constructors { get; set; }
        public IList<Method60> methods { get; set; }
        public IList<Property35> properties { get; set; }
    }

    public class Parameter62
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method61
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter62> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property36
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CaseCommentEventType
    {
        public IList<object> constructors { get; set; }
        public IList<Method61> methods { get; set; }
        public IList<Property36> properties { get; set; }
    }

    public class Parameter63
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method62
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter63> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Chatter
    {
        public IList<object> constructors { get; set; }
        public IList<Method62> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor35
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter64
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method63
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter64> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property37
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ChatterActivity
    {
        public IList<Constructor35> constructors { get; set; }
        public IList<Method63> methods { get; set; }
        public IList<Property37> properties { get; set; }
    }

    public class Constructor36
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter65
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method64
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter65> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property38
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ChatterConversation
    {
        public IList<Constructor36> constructors { get; set; }
        public IList<Method64> methods { get; set; }
        public IList<Property38> properties { get; set; }
    }

    public class Constructor37
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter66
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method65
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter66> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property39
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ChatterConversationPage
    {
        public IList<Constructor37> constructors { get; set; }
        public IList<Method65> methods { get; set; }
        public IList<Property39> properties { get; set; }
    }

    public class Constructor38
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter67
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method66
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter67> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property40
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ChatterConversationSummary
    {
        public IList<Constructor38> constructors { get; set; }
        public IList<Method66> methods { get; set; }
        public IList<Property40> properties { get; set; }
    }

    public class Parameter68
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method67
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter68> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ChatterFavorites
    {
        public IList<object> constructors { get; set; }
        public IList<Method67> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter69
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method68
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter69> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ChatterFeeds
    {
        public IList<object> constructors { get; set; }
        public IList<Method68> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter70
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method69
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter70> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property41
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ChatterGroup
    {
        public IList<object> constructors { get; set; }
        public IList<Method69> methods { get; set; }
        public IList<Property41> properties { get; set; }
    }

    public class Constructor39
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter71
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method70
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter71> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property42
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ChatterGroupDetail
    {
        public IList<Constructor39> constructors { get; set; }
        public IList<Method70> methods { get; set; }
        public IList<Property42> properties { get; set; }
    }

    public class Constructor40
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter72
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method71
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter72> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property43
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ChatterGroupInput
    {
        public IList<Constructor40> constructors { get; set; }
        public IList<Method71> methods { get; set; }
        public IList<Property43> properties { get; set; }
    }

    public class Constructor41
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter73
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method72
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter73> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property44
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ChatterGroupPage
    {
        public IList<Constructor41> constructors { get; set; }
        public IList<Method72> methods { get; set; }
        public IList<Property44> properties { get; set; }
    }

    public class Constructor42
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter74
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method73
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter74> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property45
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ChatterGroupSummary
    {
        public IList<Constructor42> constructors { get; set; }
        public IList<Method73> methods { get; set; }
        public IList<Property45> properties { get; set; }
    }

    public class Parameter75
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method74
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter75> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ChatterGroups
    {
        public IList<object> constructors { get; set; }
        public IList<Method74> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor43
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter76
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method75
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter76> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property46
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ChatterLike
    {
        public IList<Constructor43> constructors { get; set; }
        public IList<Method75> methods { get; set; }
        public IList<Property46> properties { get; set; }
    }

    public class Constructor44
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter77
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method76
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter77> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property47
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ChatterLikePage
    {
        public IList<Constructor44> constructors { get; set; }
        public IList<Method76> methods { get; set; }
        public IList<Property47> properties { get; set; }
    }

    public class Constructor45
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter78
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method77
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter78> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property48
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ChatterLikesCapability
    {
        public IList<Constructor45> constructors { get; set; }
        public IList<Method77> methods { get; set; }
        public IList<Property48> properties { get; set; }
    }

    public class Constructor46
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter79
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method78
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter79> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property49
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ChatterMessage
    {
        public IList<Constructor46> constructors { get; set; }
        public IList<Method78> methods { get; set; }
        public IList<Property49> properties { get; set; }
    }

    public class Constructor47
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter80
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method79
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter80> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property50
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ChatterMessagePage
    {
        public IList<Constructor47> constructors { get; set; }
        public IList<Method79> methods { get; set; }
        public IList<Property50> properties { get; set; }
    }

    public class Parameter81
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method80
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter81> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ChatterMessages
    {
        public IList<object> constructors { get; set; }
        public IList<Method80> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter82
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method81
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter82> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ChatterUsers
    {
        public IList<object> constructors { get; set; }
        public IList<Method81> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor48
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter83
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method82
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter83> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property51
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ClientInfo
    {
        public IList<Constructor48> constructors { get; set; }
        public IList<Method82> methods { get; set; }
        public IList<Property51> properties { get; set; }
    }

    public class Constructor49
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter84
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method83
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter84> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property52
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Comment
    {
        public IList<Constructor49> constructors { get; set; }
        public IList<Method83> methods { get; set; }
        public IList<Property52> properties { get; set; }
    }

    public class Constructor50
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter85
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method84
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter85> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property53
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CommentCapabilities
    {
        public IList<Constructor50> constructors { get; set; }
        public IList<Method84> methods { get; set; }
        public IList<Property53> properties { get; set; }
    }

    public class Constructor51
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter86
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method85
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter86> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property54
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CommentCapabilitiesInput
    {
        public IList<Constructor51> constructors { get; set; }
        public IList<Method85> methods { get; set; }
        public IList<Property54> properties { get; set; }
    }

    public class Constructor52
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter87
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method86
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter87> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property55
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CommentInput
    {
        public IList<Constructor52> constructors { get; set; }
        public IList<Method86> methods { get; set; }
        public IList<Property55> properties { get; set; }
    }

    public class Constructor53
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter88
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method87
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter88> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property56
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CommentPage
    {
        public IList<Constructor53> constructors { get; set; }
        public IList<Method87> methods { get; set; }
        public IList<Property56> properties { get; set; }
    }

    public class Parameter89
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method88
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter89> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property57
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CommentType
    {
        public IList<object> constructors { get; set; }
        public IList<Method88> methods { get; set; }
        public IList<Property57> properties { get; set; }
    }

    public class Constructor54
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter90
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method89
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter90> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property58
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CommentsCapability
    {
        public IList<Constructor54> constructors { get; set; }
        public IList<Method89> methods { get; set; }
        public IList<Property58> properties { get; set; }
    }

    public class Parameter91
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method90
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter91> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Communities
    {
        public IList<object> constructors { get; set; }
        public IList<Method90> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor55
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter92
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method91
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter92> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property59
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Community
    {
        public IList<Constructor55> constructors { get; set; }
        public IList<Method91> methods { get; set; }
        public IList<Property59> properties { get; set; }
    }

    public class Parameter93
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method92
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter93> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property60
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CommunityFlagVisibility
    {
        public IList<object> constructors { get; set; }
        public IList<Method92> methods { get; set; }
        public IList<Property60> properties { get; set; }
    }

    public class Parameter94
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method93
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter94> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class CommunityModeration
    {
        public IList<object> constructors { get; set; }
        public IList<Method93> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor56
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter95
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method94
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter95> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property61
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CommunityPage
    {
        public IList<Constructor56> constructors { get; set; }
        public IList<Method94> methods { get; set; }
        public IList<Property61> properties { get; set; }
    }

    public class Parameter96
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method95
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter96> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property62
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CommunityStatus
    {
        public IList<object> constructors { get; set; }
        public IList<Method95> methods { get; set; }
        public IList<Property62> properties { get; set; }
    }

    public class Parameter97
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method96
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter97> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property63
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ComplexSegment
    {
        public IList<object> constructors { get; set; }
        public IList<Method96> methods { get; set; }
        public IList<Property63> properties { get; set; }
    }

    public class Constructor57
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter98
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method97
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter98> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property64
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CompoundRecordField
    {
        public IList<Constructor57> constructors { get; set; }
        public IList<Method97> methods { get; set; }
        public IList<Property64> properties { get; set; }
    }

    public class Method98
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ConnectApiException
    {
        public IList<object> constructors { get; set; }
        public IList<Method98> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor58
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter99
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method99
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter99> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property65
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ContentAttachment
    {
        public IList<Constructor58> constructors { get; set; }
        public IList<Method99> methods { get; set; }
        public IList<Property65> properties { get; set; }
    }

    public class Constructor59
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter100
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method100
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter100> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property66
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ContentAttachmentInput
    {
        public IList<Constructor59> constructors { get; set; }
        public IList<Method100> methods { get; set; }
        public IList<Property66> properties { get; set; }
    }

    public class Constructor60
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter101
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method101
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter101> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property67
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ContentCapability
    {
        public IList<Constructor60> constructors { get; set; }
        public IList<Method101> methods { get; set; }
        public IList<Property67> properties { get; set; }
    }

    public class Constructor61
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter102
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method102
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter102> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property68
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ContentCapabilityInput
    {
        public IList<Constructor61> constructors { get; set; }
        public IList<Method102> methods { get; set; }
        public IList<Property68> properties { get; set; }
    }

    public class Constructor62
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter103
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method103
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter103> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class CurrencyRecordField
    {
        public IList<Constructor62> constructors { get; set; }
        public IList<Method103> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor63
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter104
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method104
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter104> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property69
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class DashboardComponentAttachment
    {
        public IList<Constructor63> constructors { get; set; }
        public IList<Method104> methods { get; set; }
        public IList<Property69> properties { get; set; }
    }

    public class Constructor64
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter105
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method105
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter105> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property70
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class DashboardComponentSnapshot
    {
        public IList<Constructor64> constructors { get; set; }
        public IList<Method105> methods { get; set; }
        public IList<Property70> properties { get; set; }
    }

    public class Constructor65
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter106
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method106
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter106> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property71
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class DashboardComponentSnapshotCapability
    {
        public IList<Constructor65> constructors { get; set; }
        public IList<Method106> methods { get; set; }
        public IList<Property71> properties { get; set; }
    }

    public class Parameter107
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method107
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter107> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Datacloud
    {
        public IList<object> constructors { get; set; }
        public IList<Method107> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor66
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter108
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method108
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter108> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property72
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class DatacloudCompanies
    {
        public IList<Constructor66> constructors { get; set; }
        public IList<Method108> methods { get; set; }
        public IList<Property72> properties { get; set; }
    }

    public class Constructor67
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter109
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method109
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter109> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property73
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class DatacloudCompany
    {
        public IList<Constructor67> constructors { get; set; }
        public IList<Method109> methods { get; set; }
        public IList<Property73> properties { get; set; }
    }

    public class Constructor68
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter110
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method110
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter110> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property74
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class DatacloudContact
    {
        public IList<Constructor68> constructors { get; set; }
        public IList<Method110> methods { get; set; }
        public IList<Property74> properties { get; set; }
    }

    public class Constructor69
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter111
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method111
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter111> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property75
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class DatacloudContacts
    {
        public IList<Constructor69> constructors { get; set; }
        public IList<Method111> methods { get; set; }
        public IList<Property75> properties { get; set; }
    }

    public class Constructor70
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter112
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method112
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter112> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property76
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class DatacloudOrder
    {
        public IList<Constructor70> constructors { get; set; }
        public IList<Method112> methods { get; set; }
        public IList<Property76> properties { get; set; }
    }

    public class Constructor71
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter113
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method113
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter113> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property77
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class DatacloudOrderInput
    {
        public IList<Constructor71> constructors { get; set; }
        public IList<Method113> methods { get; set; }
        public IList<Property77> properties { get; set; }
    }

    public class Constructor72
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter114
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method114
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter114> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property78
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class DatacloudPurchaseUsage
    {
        public IList<Constructor72> constructors { get; set; }
        public IList<Method114> methods { get; set; }
        public IList<Property78> properties { get; set; }
    }

    public class Parameter115
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method115
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter115> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property79
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class DatacloudUserType
    {
        public IList<object> constructors { get; set; }
        public IList<Method115> methods { get; set; }
        public IList<Property79> properties { get; set; }
    }

    public class Constructor73
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter116
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method116
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter116> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property80
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class DateRecordField
    {
        public IList<Constructor73> constructors { get; set; }
        public IList<Method116> methods { get; set; }
        public IList<Property80> properties { get; set; }
    }

    public class Constructor74
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter117
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method117
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter117> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property81
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class EmailAddress
    {
        public IList<Constructor74> constructors { get; set; }
        public IList<Method117> methods { get; set; }
        public IList<Property81> properties { get; set; }
    }

    public class Constructor75
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter118
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method118
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter118> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property82
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class EmailMessage
    {
        public IList<Constructor75> constructors { get; set; }
        public IList<Method118> methods { get; set; }
        public IList<Property82> properties { get; set; }
    }

    public class Constructor76
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter119
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method119
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter119> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property83
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class EmailMessageCapability
    {
        public IList<Constructor76> constructors { get; set; }
        public IList<Method119> methods { get; set; }
        public IList<Property83> properties { get; set; }
    }

    public class Parameter120
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method120
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter120> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property84
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class EmailMessageDirection
    {
        public IList<object> constructors { get; set; }
        public IList<Method120> methods { get; set; }
        public IList<Property84> properties { get; set; }
    }

    public class Constructor77
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter121
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method121
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter121> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property85
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class EnhancedLinkCapability
    {
        public IList<Constructor77> constructors { get; set; }
        public IList<Method121> methods { get; set; }
        public IList<Property85> properties { get; set; }
    }

    public class Constructor78
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter122
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method122
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter122> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property86
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class EntityLinkSegment
    {
        public IList<Constructor78> constructors { get; set; }
        public IList<Method122> methods { get; set; }
        public IList<Property86> properties { get; set; }
    }

    public class Constructor79
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter123
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method123
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter123> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property87
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class EntityRecommendation
    {
        public IList<Constructor79> constructors { get; set; }
        public IList<Method123> methods { get; set; }
        public IList<Property87> properties { get; set; }
    }

    public class Constructor80
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter124
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method124
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter124> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property88
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Features
    {
        public IList<Constructor80> constructors { get; set; }
        public IList<Method124> methods { get; set; }
        public IList<Property88> properties { get; set; }
    }

    public class Constructor81
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter125
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method125
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter125> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property89
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Feed
    {
        public IList<Constructor81> constructors { get; set; }
        public IList<Method125> methods { get; set; }
        public IList<Property89> properties { get; set; }
    }

    public class Constructor82
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter126
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method126
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter126> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class FeedBody
    {
        public IList<Constructor82> constructors { get; set; }
        public IList<Method126> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter127
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method127
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter127> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property90
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedDensity
    {
        public IList<object> constructors { get; set; }
        public IList<Method127> methods { get; set; }
        public IList<Property90> properties { get; set; }
    }

    public class Constructor83
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter128
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method128
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter128> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property91
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedDirectory
    {
        public IList<Constructor83> constructors { get; set; }
        public IList<Method128> methods { get; set; }
        public IList<Property91> properties { get; set; }
    }

    public class Constructor84
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter129
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method129
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter129> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property92
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedDirectoryItem
    {
        public IList<Constructor84> constructors { get; set; }
        public IList<Method129> methods { get; set; }
        public IList<Property92> properties { get; set; }
    }

    public class Parameter130
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method130
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter130> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property93
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedElement
    {
        public IList<object> constructors { get; set; }
        public IList<Method130> methods { get; set; }
        public IList<Property93> properties { get; set; }
    }

    public class Constructor85
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter131
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method131
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter131> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property94
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedElementCapabilities
    {
        public IList<Constructor85> constructors { get; set; }
        public IList<Method131> methods { get; set; }
        public IList<Property94> properties { get; set; }
    }

    public class Constructor86
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter132
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method132
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter132> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property95
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedElementCapabilitiesInput
    {
        public IList<Constructor86> constructors { get; set; }
        public IList<Method132> methods { get; set; }
        public IList<Property95> properties { get; set; }
    }

    public class Parameter133
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method133
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter133> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class FeedElementCapability
    {
        public IList<object> constructors { get; set; }
        public IList<Method133> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter134
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method134
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter134> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class FeedElementCapabilityInput
    {
        public IList<object> constructors { get; set; }
        public IList<Method134> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter135
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method135
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter135> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property96
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedElementCapabilityType
    {
        public IList<object> constructors { get; set; }
        public IList<Method135> methods { get; set; }
        public IList<Property96> properties { get; set; }
    }

    public class Parameter136
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method136
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter136> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property97
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedElementInput
    {
        public IList<object> constructors { get; set; }
        public IList<Method136> methods { get; set; }
        public IList<Property97> properties { get; set; }
    }

    public class Constructor87
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter137
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method137
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter137> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property98
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedElementPage
    {
        public IList<Constructor87> constructors { get; set; }
        public IList<Method137> methods { get; set; }
        public IList<Property98> properties { get; set; }
    }

    public class Parameter138
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method138
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter138> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property99
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedElementType
    {
        public IList<object> constructors { get; set; }
        public IList<Method138> methods { get; set; }
        public IList<Property99> properties { get; set; }
    }

    public class Constructor88
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter139
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method139
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter139> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property100
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedFavorite
    {
        public IList<Constructor88> constructors { get; set; }
        public IList<Method139> methods { get; set; }
        public IList<Property100> properties { get; set; }
    }

    public class Parameter140
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method140
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter140> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property101
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedFavoriteType
    {
        public IList<object> constructors { get; set; }
        public IList<Method140> methods { get; set; }
        public IList<Property101> properties { get; set; }
    }

    public class Constructor89
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter141
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method141
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter141> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property102
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedFavorites
    {
        public IList<Constructor89> constructors { get; set; }
        public IList<Method141> methods { get; set; }
        public IList<Property102> properties { get; set; }
    }

    public class Parameter142
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method142
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter142> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property103
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedFilter
    {
        public IList<object> constructors { get; set; }
        public IList<Method142> methods { get; set; }
        public IList<Property103> properties { get; set; }
    }

    public class Constructor90
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter143
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method143
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter143> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property104
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedItem
    {
        public IList<Constructor90> constructors { get; set; }
        public IList<Method143> methods { get; set; }
        public IList<Property104> properties { get; set; }
    }

    public class Parameter144
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method144
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter144> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property105
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedItemAttachment
    {
        public IList<object> constructors { get; set; }
        public IList<Method144> methods { get; set; }
        public IList<Property105> properties { get; set; }
    }

    public class Parameter145
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method145
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter145> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class FeedItemAttachmentInput
    {
        public IList<object> constructors { get; set; }
        public IList<Method145> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter146
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method146
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter146> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property106
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedItemAttachmentType
    {
        public IList<object> constructors { get; set; }
        public IList<Method146> methods { get; set; }
        public IList<Property106> properties { get; set; }
    }

    public class Constructor91
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter147
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method147
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter147> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property107
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedItemInput
    {
        public IList<Constructor91> constructors { get; set; }
        public IList<Method147> methods { get; set; }
        public IList<Property107> properties { get; set; }
    }

    public class Constructor92
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter148
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method148
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter148> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property108
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedItemPage
    {
        public IList<Constructor92> constructors { get; set; }
        public IList<Method148> methods { get; set; }
        public IList<Property108> properties { get; set; }
    }

    public class Constructor93
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter149
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method149
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter149> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property109
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedItemTopicPage
    {
        public IList<Constructor93> constructors { get; set; }
        public IList<Method149> methods { get; set; }
        public IList<Property109> properties { get; set; }
    }

    public class Parameter150
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method150
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter150> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property110
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedItemType
    {
        public IList<object> constructors { get; set; }
        public IList<Method150> methods { get; set; }
        public IList<Property110> properties { get; set; }
    }

    public class Parameter151
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method151
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter151> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property111
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedItemVisibilityType
    {
        public IList<object> constructors { get; set; }
        public IList<Method151> methods { get; set; }
        public IList<Property111> properties { get; set; }
    }

    public class Constructor94
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter152
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method152
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter152> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property112
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedModifiedInfo
    {
        public IList<Constructor94> constructors { get; set; }
        public IList<Method152> methods { get; set; }
        public IList<Property112> properties { get; set; }
    }

    public class Constructor95
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter153
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method153
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter153> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property113
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedPoll
    {
        public IList<Constructor95> constructors { get; set; }
        public IList<Method153> methods { get; set; }
        public IList<Property113> properties { get; set; }
    }

    public class Constructor96
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter154
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method154
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter154> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property114
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedPollChoice
    {
        public IList<Constructor96> constructors { get; set; }
        public IList<Method154> methods { get; set; }
        public IList<Property114> properties { get; set; }
    }

    public class Parameter155
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method155
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter155> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property115
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedSortOrder
    {
        public IList<object> constructors { get; set; }
        public IList<Method155> methods { get; set; }
        public IList<Property115> properties { get; set; }
    }

    public class Parameter156
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method156
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter156> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property116
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FeedType
    {
        public IList<object> constructors { get; set; }
        public IList<Method156> methods { get; set; }
        public IList<Property116> properties { get; set; }
    }

    public class Constructor97
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter157
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method157
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter157> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class FieldChangeNameSegment
    {
        public IList<Constructor97> constructors { get; set; }
        public IList<Method157> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor98
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter158
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method158
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter158> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class FieldChangeSegment
    {
        public IList<Constructor98> constructors { get; set; }
        public IList<Method158> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor99
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter159
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method159
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter159> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property117
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FieldChangeValueSegment
    {
        public IList<Constructor99> constructors { get; set; }
        public IList<Method159> methods { get; set; }
        public IList<Property117> properties { get; set; }
    }

    public class Parameter160
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method160
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter160> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property118
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FieldChangeValueType
    {
        public IList<object> constructors { get; set; }
        public IList<Method160> methods { get; set; }
        public IList<Property118> properties { get; set; }
    }

    public class Parameter161
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method161
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter161> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property119
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class File
    {
        public IList<object> constructors { get; set; }
        public IList<Method161> methods { get; set; }
        public IList<Property119> properties { get; set; }
    }

    public class Parameter162
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method162
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter162> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property120
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FilePublishStatus
    {
        public IList<object> constructors { get; set; }
        public IList<Method162> methods { get; set; }
        public IList<Property120> properties { get; set; }
    }

    public class Parameter163
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method163
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter163> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property121
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FileSharingType
    {
        public IList<object> constructors { get; set; }
        public IList<Method163> methods { get; set; }
        public IList<Property121> properties { get; set; }
    }

    public class Constructor100
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter164
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method164
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter164> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class FileSummary
    {
        public IList<Constructor100> constructors { get; set; }
        public IList<Method164> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor101
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter165
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method165
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter165> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property122
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FollowerPage
    {
        public IList<Constructor101> constructors { get; set; }
        public IList<Method165> methods { get; set; }
        public IList<Property122> properties { get; set; }
    }

    public class Constructor102
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter166
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method166
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter166> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property123
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FollowingCounts
    {
        public IList<Constructor102> constructors { get; set; }
        public IList<Method166> methods { get; set; }
        public IList<Property123> properties { get; set; }
    }

    public class Constructor103
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter167
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method167
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter167> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property124
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FollowingPage
    {
        public IList<Constructor103> constructors { get; set; }
        public IList<Method167> methods { get; set; }
        public IList<Property124> properties { get; set; }
    }

    public class Constructor104
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter168
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method168
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter168> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class GenericBundleCapability
    {
        public IList<Constructor104> constructors { get; set; }
        public IList<Method168> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor105
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter169
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method169
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter169> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class GenericFeedElement
    {
        public IList<Constructor105> constructors { get; set; }
        public IList<Method169> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor106
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter170
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method170
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter170> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property125
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class GlobalInfluence
    {
        public IList<Constructor106> constructors { get; set; }
        public IList<Method170> methods { get; set; }
        public IList<Property125> properties { get; set; }
    }

    public class Parameter171
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method171
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter171> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property126
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class GroupArchiveStatus
    {
        public IList<object> constructors { get; set; }
        public IList<Method171> methods { get; set; }
        public IList<Property126> properties { get; set; }
    }

    public class Constructor107
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter172
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method172
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter172> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property127
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class GroupChatterSettings
    {
        public IList<Constructor107> constructors { get; set; }
        public IList<Method172> methods { get; set; }
        public IList<Property127> properties { get; set; }
    }

    public class Parameter173
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method173
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter173> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property128
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class GroupEmailFrequency
    {
        public IList<object> constructors { get; set; }
        public IList<Method173> methods { get; set; }
        public IList<Property128> properties { get; set; }
    }

    public class Constructor108
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter174
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method174
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter174> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property129
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class GroupInformation
    {
        public IList<Constructor108> constructors { get; set; }
        public IList<Method174> methods { get; set; }
        public IList<Property129> properties { get; set; }
    }

    public class Constructor109
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter175
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method175
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter175> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property130
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class GroupInformationInput
    {
        public IList<Constructor109> constructors { get; set; }
        public IList<Method175> methods { get; set; }
        public IList<Property130> properties { get; set; }
    }

    public class Constructor110
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter176
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method176
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter176> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property131
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class GroupMember
    {
        public IList<Constructor110> constructors { get; set; }
        public IList<Method176> methods { get; set; }
        public IList<Property131> properties { get; set; }
    }

    public class Constructor111
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter177
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method177
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter177> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property132
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class GroupMemberPage
    {
        public IList<Constructor111> constructors { get; set; }
        public IList<Method177> methods { get; set; }
        public IList<Property132> properties { get; set; }
    }

    public class Constructor112
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter178
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method178
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter178> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property133
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class GroupMembershipRequest
    {
        public IList<Constructor112> constructors { get; set; }
        public IList<Method178> methods { get; set; }
        public IList<Property133> properties { get; set; }
    }

    public class Parameter179
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method179
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter179> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property134
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class GroupMembershipRequestStatus
    {
        public IList<object> constructors { get; set; }
        public IList<Method179> methods { get; set; }
        public IList<Property134> properties { get; set; }
    }

    public class Constructor113
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter180
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method180
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter180> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property135
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class GroupMembershipRequests
    {
        public IList<Constructor113> constructors { get; set; }
        public IList<Method180> methods { get; set; }
        public IList<Property135> properties { get; set; }
    }

    public class Parameter181
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method181
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter181> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property136
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class GroupMembershipType
    {
        public IList<object> constructors { get; set; }
        public IList<Method181> methods { get; set; }
        public IList<Property136> properties { get; set; }
    }

    public class Constructor114
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter182
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method182
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter182> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property137
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class GroupRecord
    {
        public IList<Constructor114> constructors { get; set; }
        public IList<Method182> methods { get; set; }
        public IList<Property137> properties { get; set; }
    }

    public class Constructor115
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter183
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method183
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter183> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property138
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class GroupRecordPage
    {
        public IList<Constructor115> constructors { get; set; }
        public IList<Method183> methods { get; set; }
        public IList<Property138> properties { get; set; }
    }

    public class Parameter184
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method184
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter184> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property139
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class GroupVisibilityType
    {
        public IList<object> constructors { get; set; }
        public IList<Method184> methods { get; set; }
        public IList<Property139> properties { get; set; }
    }

    public class Constructor116
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter185
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method185
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter185> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property140
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class HashtagSegment
    {
        public IList<Constructor116> constructors { get; set; }
        public IList<Method185> methods { get; set; }
        public IList<Property140> properties { get; set; }
    }

    public class Constructor117
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter186
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method186
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter186> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property141
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class HashtagSegmentInput
    {
        public IList<Constructor117> constructors { get; set; }
        public IList<Method186> methods { get; set; }
        public IList<Property141> properties { get; set; }
    }

    public class Constructor118
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter187
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method187
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter187> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property142
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Icon
    {
        public IList<Constructor118> constructors { get; set; }
        public IList<Method187> methods { get; set; }
        public IList<Property142> properties { get; set; }
    }

    public class Parameter188
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method188
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter188> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property143
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class LabeledRecordField
    {
        public IList<object> constructors { get; set; }
        public IList<Method188> methods { get; set; }
        public IList<Property143> properties { get; set; }
    }

    public class Constructor119
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter189
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method189
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter189> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property144
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class LinkAttachment
    {
        public IList<Constructor119> constructors { get; set; }
        public IList<Method189> methods { get; set; }
        public IList<Property144> properties { get; set; }
    }

    public class Constructor120
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter190
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method190
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter190> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property145
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class LinkAttachmentInput
    {
        public IList<Constructor120> constructors { get; set; }
        public IList<Method190> methods { get; set; }
        public IList<Property145> properties { get; set; }
    }

    public class Constructor121
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter191
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method191
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter191> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property146
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class LinkCapability
    {
        public IList<Constructor121> constructors { get; set; }
        public IList<Method191> methods { get; set; }
        public IList<Property146> properties { get; set; }
    }

    public class Constructor122
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter192
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method192
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter192> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property147
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class LinkCapabilityInput
    {
        public IList<Constructor122> constructors { get; set; }
        public IList<Method192> methods { get; set; }
        public IList<Property147> properties { get; set; }
    }

    public class Constructor123
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter193
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method193
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter193> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property148
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class LinkSegment
    {
        public IList<Constructor123> constructors { get; set; }
        public IList<Method193> methods { get; set; }
        public IList<Property148> properties { get; set; }
    }

    public class Constructor124
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter194
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method194
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter194> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property149
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class LinkSegmentInput
    {
        public IList<Constructor124> constructors { get; set; }
        public IList<Method194> methods { get; set; }
        public IList<Property149> properties { get; set; }
    }

    public class Constructor125
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter195
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method195
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter195> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property150
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ManagedTopic
    {
        public IList<Constructor125> constructors { get; set; }
        public IList<Method195> methods { get; set; }
        public IList<Property150> properties { get; set; }
    }

    public class Constructor126
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter196
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method196
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter196> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property151
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ManagedTopicCollection
    {
        public IList<Constructor126> constructors { get; set; }
        public IList<Method196> methods { get; set; }
        public IList<Property151> properties { get; set; }
    }

    public class Constructor127
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter197
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method197
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter197> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property152
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ManagedTopicPositionCollectionInput
    {
        public IList<Constructor127> constructors { get; set; }
        public IList<Method197> methods { get; set; }
        public IList<Property152> properties { get; set; }
    }

    public class Constructor128
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter198
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method198
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter198> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property153
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ManagedTopicPositionInput
    {
        public IList<Constructor128> constructors { get; set; }
        public IList<Method198> methods { get; set; }
        public IList<Property153> properties { get; set; }
    }

    public class Parameter199
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method199
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter199> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property154
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ManagedTopicType
    {
        public IList<object> constructors { get; set; }
        public IList<Method199> methods { get; set; }
        public IList<Property154> properties { get; set; }
    }

    public class Parameter200
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method200
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter200> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ManagedTopics
    {
        public IList<object> constructors { get; set; }
        public IList<Method200> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor129
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter201
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method201
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter201> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property155
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class MentionCompletion
    {
        public IList<Constructor129> constructors { get; set; }
        public IList<Method201> methods { get; set; }
        public IList<Property155> properties { get; set; }
    }

    public class Constructor130
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter202
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method202
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter202> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property156
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class MentionCompletionPage
    {
        public IList<Constructor130> constructors { get; set; }
        public IList<Method202> methods { get; set; }
        public IList<Property156> properties { get; set; }
    }

    public class Parameter203
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method203
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter203> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property157
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class MentionCompletionType
    {
        public IList<object> constructors { get; set; }
        public IList<Method203> methods { get; set; }
        public IList<Property157> properties { get; set; }
    }

    public class Constructor131
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter204
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method204
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter204> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property158
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class MentionSegment
    {
        public IList<Constructor131> constructors { get; set; }
        public IList<Method204> methods { get; set; }
        public IList<Property158> properties { get; set; }
    }

    public class Constructor132
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter205
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method205
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter205> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property159
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class MentionSegmentInput
    {
        public IList<Constructor132> constructors { get; set; }
        public IList<Method205> methods { get; set; }
        public IList<Property159> properties { get; set; }
    }

    public class Constructor133
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter206
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method206
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter206> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property160
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class MentionValidation
    {
        public IList<Constructor133> constructors { get; set; }
        public IList<Method206> methods { get; set; }
        public IList<Property160> properties { get; set; }
    }

    public class Parameter207
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method207
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter207> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property161
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class MentionValidationStatus
    {
        public IList<object> constructors { get; set; }
        public IList<Method207> methods { get; set; }
        public IList<Property161> properties { get; set; }
    }

    public class Constructor134
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter208
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method208
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter208> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property162
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class MentionValidations
    {
        public IList<Constructor134> constructors { get; set; }
        public IList<Method208> methods { get; set; }
        public IList<Property162> properties { get; set; }
    }

    public class Parameter209
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method209
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter209> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Mentions
    {
        public IList<object> constructors { get; set; }
        public IList<Method209> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor135
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter210
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method210
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter210> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class MessageBody
    {
        public IList<Constructor135> constructors { get; set; }
        public IList<Method210> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor136
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter211
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method211
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter211> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property163
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class MessageBodyInput
    {
        public IList<Constructor136> constructors { get; set; }
        public IList<Method211> methods { get; set; }
        public IList<Property163> properties { get; set; }
    }

    public class Parameter212
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method212
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter212> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property164
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class MessageSegment
    {
        public IList<object> constructors { get; set; }
        public IList<Method212> methods { get; set; }
        public IList<Property164> properties { get; set; }
    }

    public class Parameter213
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method213
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter213> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class MessageSegmentInput
    {
        public IList<object> constructors { get; set; }
        public IList<Method213> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter214
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method214
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter214> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property165
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class MessageSegmentType
    {
        public IList<object> constructors { get; set; }
        public IList<Method214> methods { get; set; }
        public IList<Property165> properties { get; set; }
    }

    public class Constructor137
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter215
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method215
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter215> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property166
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ModerationCapability
    {
        public IList<Constructor137> constructors { get; set; }
        public IList<Method215> methods { get; set; }
        public IList<Property166> properties { get; set; }
    }

    public class Constructor138
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter216
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method216
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter216> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property167
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ModerationFlags
    {
        public IList<Constructor138> constructors { get; set; }
        public IList<Method216> methods { get; set; }
        public IList<Property167> properties { get; set; }
    }

    public class Constructor139
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter217
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method217
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter217> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property168
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class MoreChangesSegment
    {
        public IList<Constructor139> constructors { get; set; }
        public IList<Method217> methods { get; set; }
        public IList<Property168> properties { get; set; }
    }

    public class Constructor140
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter218
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method218
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter218> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property169
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Motif
    {
        public IList<Constructor140> constructors { get; set; }
        public IList<Method218> methods { get; set; }
        public IList<Property169> properties { get; set; }
    }

    public class Constructor141
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter219
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method219
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter219> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property170
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class NewFileAttachmentInput
    {
        public IList<Constructor141> constructors { get; set; }
        public IList<Method219> methods { get; set; }
        public IList<Property170> properties { get; set; }
    }

    public class Constructor142
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter220
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method220
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter220> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property171
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class NonEntityRecommendation
    {
        public IList<Constructor142> constructors { get; set; }
        public IList<Method220> methods { get; set; }
        public IList<Property171> properties { get; set; }
    }

    public class Method221
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class NotFoundException
    {
        public IList<object> constructors { get; set; }
        public IList<Method221> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method222
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Organization
    {
        public IList<object> constructors { get; set; }
        public IList<Method222> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor143
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter221
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method223
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter221> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property172
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class OrganizationSettings
    {
        public IList<Constructor143> constructors { get; set; }
        public IList<Method223> methods { get; set; }
        public IList<Property172> properties { get; set; }
    }

    public class Constructor144
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter222
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method224
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter222> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property173
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class PercentRecordField
    {
        public IList<Constructor144> constructors { get; set; }
        public IList<Method224> methods { get; set; }
        public IList<Property173> properties { get; set; }
    }

    public class Constructor145
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter223
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method225
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter223> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property174
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class PhoneNumber
    {
        public IList<Constructor145> constructors { get; set; }
        public IList<Method225> methods { get; set; }
        public IList<Property174> properties { get; set; }
    }

    public class Constructor146
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter224
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method226
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter224> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property175
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Photo
    {
        public IList<Constructor146> constructors { get; set; }
        public IList<Method226> methods { get; set; }
        public IList<Property175> properties { get; set; }
    }

    public class Constructor147
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter225
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method227
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter225> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property176
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class PhotoInput
    {
        public IList<Constructor147> constructors { get; set; }
        public IList<Method227> methods { get; set; }
        public IList<Property176> properties { get; set; }
    }

    public class Constructor148
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter226
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method228
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter226> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class PicklistRecordField
    {
        public IList<Constructor148> constructors { get; set; }
        public IList<Method228> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor149
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter227
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method229
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter227> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property177
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class PollAttachmentInput
    {
        public IList<Constructor149> constructors { get; set; }
        public IList<Method229> methods { get; set; }
        public IList<Property177> properties { get; set; }
    }

    public class Constructor150
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter228
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method230
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter228> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property178
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class PollCapability
    {
        public IList<Constructor150> constructors { get; set; }
        public IList<Method230> methods { get; set; }
        public IList<Property178> properties { get; set; }
    }

    public class Constructor151
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter229
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method231
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter229> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property179
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class PollCapabilityInput
    {
        public IList<Constructor151> constructors { get; set; }
        public IList<Method231> methods { get; set; }
        public IList<Property179> properties { get; set; }
    }

    public class Parameter230
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method232
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter230> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class QuestionAndAnswers
    {
        public IList<object> constructors { get; set; }
        public IList<Method232> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor152
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter231
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method233
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter231> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property180
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class QuestionAndAnswersCapability
    {
        public IList<Constructor152> constructors { get; set; }
        public IList<Method233> methods { get; set; }
        public IList<Property180> properties { get; set; }
    }

    public class Constructor153
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter232
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method234
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter232> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property181
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class QuestionAndAnswersCapabilityInput
    {
        public IList<Constructor153> constructors { get; set; }
        public IList<Method234> methods { get; set; }
        public IList<Property181> properties { get; set; }
    }

    public class Constructor154
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter233
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method235
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter233> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property182
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class QuestionAndAnswersSuggestions
    {
        public IList<Constructor154> constructors { get; set; }
        public IList<Method235> methods { get; set; }
        public IList<Property182> properties { get; set; }
    }

    public class Constructor155
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter234
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method236
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter234> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property183
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class QuestionAttachment
    {
        public IList<Constructor155> constructors { get; set; }
        public IList<Method236> methods { get; set; }
        public IList<Property183> properties { get; set; }
    }

    public class Constructor156
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter235
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method237
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter235> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property184
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class QuestionAttachmentInput
    {
        public IList<Constructor156> constructors { get; set; }
        public IList<Method237> methods { get; set; }
        public IList<Property184> properties { get; set; }
    }

    public class Method238
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class RateLimitException
    {
        public IList<object> constructors { get; set; }
        public IList<Method238> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter236
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method239
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter236> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property185
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class RecommendationActionType
    {
        public IList<object> constructors { get; set; }
        public IList<Method239> methods { get; set; }
        public IList<Property185> properties { get; set; }
    }

    public class Constructor157
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter237
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method240
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter237> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property186
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class RecommendationExplanation
    {
        public IList<Constructor157> constructors { get; set; }
        public IList<Method240> methods { get; set; }
        public IList<Property186> properties { get; set; }
    }

    public class Parameter238
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method241
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter238> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property187
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class RecommendationExplanationType
    {
        public IList<object> constructors { get; set; }
        public IList<Method241> methods { get; set; }
        public IList<Property187> properties { get; set; }
    }

    public class Parameter239
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method242
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter239> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property188
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class RecommendationType
    {
        public IList<object> constructors { get; set; }
        public IList<Method242> methods { get; set; }
        public IList<Property188> properties { get; set; }
    }

    public class Constructor158
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter240
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method243
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter240> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property189
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class RecommendationsCapability
    {
        public IList<Constructor158> constructors { get; set; }
        public IList<Method243> methods { get; set; }
        public IList<Property189> properties { get; set; }
    }

    public class Parameter241
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method244
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter241> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property190
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class RecordColumnOrder
    {
        public IList<object> constructors { get; set; }
        public IList<Method244> methods { get; set; }
        public IList<Property190> properties { get; set; }
    }

    public class Parameter242
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method245
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter242> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class RecordDetails
    {
        public IList<object> constructors { get; set; }
        public IList<Method245> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor159
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter243
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method246
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter243> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class RecordField
    {
        public IList<Constructor159> constructors { get; set; }
        public IList<Method246> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter244
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method247
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter244> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property191
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class RecordFieldType
    {
        public IList<object> constructors { get; set; }
        public IList<Method247> methods { get; set; }
        public IList<Property191> properties { get; set; }
    }

    public class Constructor160
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter245
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method248
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter245> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property192
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class RecordSnapshotAttachment
    {
        public IList<Constructor160> constructors { get; set; }
        public IList<Method248> methods { get; set; }
        public IList<Property192> properties { get; set; }
    }

    public class Constructor161
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter246
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method249
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter246> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property193
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class RecordSnapshotCapability
    {
        public IList<Constructor161> constructors { get; set; }
        public IList<Method249> methods { get; set; }
        public IList<Property193> properties { get; set; }
    }

    public class Constructor162
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter247
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method250
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter247> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class RecordSummary
    {
        public IList<Constructor162> constructors { get; set; }
        public IList<Method250> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor163
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter248
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method251
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter248> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property194
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class RecordSummaryList
    {
        public IList<Constructor163> constructors { get; set; }
        public IList<Method251> methods { get; set; }
        public IList<Property194> properties { get; set; }
    }

    public class Constructor164
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter249
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method252
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter249> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property195
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class RecordView
    {
        public IList<Constructor164> constructors { get; set; }
        public IList<Method252> methods { get; set; }
        public IList<Property195> properties { get; set; }
    }

    public class Constructor165
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter250
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method253
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter250> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property196
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class RecordViewSection
    {
        public IList<Constructor165> constructors { get; set; }
        public IList<Method253> methods { get; set; }
        public IList<Property196> properties { get; set; }
    }

    public class Parameter251
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method254
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter251> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Records
    {
        public IList<object> constructors { get; set; }
        public IList<Method254> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor166
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter252
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method255
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter252> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property197
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Reference
    {
        public IList<Constructor166> constructors { get; set; }
        public IList<Method255> methods { get; set; }
        public IList<Property197> properties { get; set; }
    }

    public class Constructor167
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter253
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method256
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter253> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property198
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ReferenceRecordField
    {
        public IList<Constructor167> constructors { get; set; }
        public IList<Method256> methods { get; set; }
        public IList<Property198> properties { get; set; }
    }

    public class Constructor168
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter254
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method257
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter254> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property199
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ReferenceWithDateRecordField
    {
        public IList<Constructor168> constructors { get; set; }
        public IList<Method257> methods { get; set; }
        public IList<Property199> properties { get; set; }
    }

    public class Constructor169
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter255
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method258
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter255> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property200
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Reputation
    {
        public IList<Constructor169> constructors { get; set; }
        public IList<Method258> methods { get; set; }
        public IList<Property200> properties { get; set; }
    }

    public class Constructor170
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter256
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method259
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter256> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property201
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ReputationLevel
    {
        public IList<Constructor170> constructors { get; set; }
        public IList<Method259> methods { get; set; }
        public IList<Property201> properties { get; set; }
    }

    public class Constructor171
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter257
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method260
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter257> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property202
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ResourceLinkSegment
    {
        public IList<Constructor171> constructors { get; set; }
        public IList<Method260> methods { get; set; }
        public IList<Property202> properties { get; set; }
    }

    public class Parameter258
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method261
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter258> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property203
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class SortOrder
    {
        public IList<object> constructors { get; set; }
        public IList<Method261> methods { get; set; }
        public IList<Property203> properties { get; set; }
    }

    public class Constructor172
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter259
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method262
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter259> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property204
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Subscription
    {
        public IList<Constructor172> constructors { get; set; }
        public IList<Method262> methods { get; set; }
        public IList<Property204> properties { get; set; }
    }

    public class Constructor173
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter260
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method263
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter260> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class TextSegment
    {
        public IList<Constructor173> constructors { get; set; }
        public IList<Method263> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor174
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter261
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method264
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter261> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property205
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class TextSegmentInput
    {
        public IList<Constructor174> constructors { get; set; }
        public IList<Method264> methods { get; set; }
        public IList<Property205> properties { get; set; }
    }

    public class Constructor175
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter262
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method265
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter262> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property206
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class TimeZone
    {
        public IList<Constructor175> constructors { get; set; }
        public IList<Method265> methods { get; set; }
        public IList<Property206> properties { get; set; }
    }

    public class Constructor176
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter263
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method266
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter263> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property207
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Topic
    {
        public IList<Constructor176> constructors { get; set; }
        public IList<Method266> methods { get; set; }
        public IList<Property207> properties { get; set; }
    }

    public class Constructor177
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter264
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method267
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter264> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property208
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class TopicImages
    {
        public IList<Constructor177> constructors { get; set; }
        public IList<Method267> methods { get; set; }
        public IList<Property208> properties { get; set; }
    }

    public class Constructor178
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter265
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method268
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter265> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property209
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class TopicInput
    {
        public IList<Constructor178> constructors { get; set; }
        public IList<Method268> methods { get; set; }
        public IList<Property209> properties { get; set; }
    }

    public class Constructor179
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter266
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method269
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter266> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property210
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class TopicPage
    {
        public IList<Constructor179> constructors { get; set; }
        public IList<Method269> methods { get; set; }
        public IList<Property210> properties { get; set; }
    }

    public class Parameter267
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method270
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter267> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property211
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class TopicSort
    {
        public IList<object> constructors { get; set; }
        public IList<Method270> methods { get; set; }
        public IList<Property211> properties { get; set; }
    }

    public class Constructor180
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter268
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method271
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter268> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property212
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class TopicSuggestion
    {
        public IList<Constructor180> constructors { get; set; }
        public IList<Method271> methods { get; set; }
        public IList<Property212> properties { get; set; }
    }

    public class Constructor181
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter269
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method272
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter269> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property213
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class TopicSuggestionPage
    {
        public IList<Constructor181> constructors { get; set; }
        public IList<Method272> methods { get; set; }
        public IList<Property213> properties { get; set; }
    }

    public class Parameter270
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method273
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter270> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Topics
    {
        public IList<object> constructors { get; set; }
        public IList<Method273> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor182
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter271
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method274
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter271> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property214
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class TopicsCapability
    {
        public IList<Constructor182> constructors { get; set; }
        public IList<Method274> methods { get; set; }
        public IList<Property214> properties { get; set; }
    }

    public class Constructor183
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter272
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method275
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter272> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property215
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class TrackedChangeAttachment
    {
        public IList<Constructor183> constructors { get; set; }
        public IList<Method275> methods { get; set; }
        public IList<Property215> properties { get; set; }
    }

    public class Constructor184
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter273
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method276
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter273> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property216
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class TrackedChangeBundleCapability
    {
        public IList<Constructor184> constructors { get; set; }
        public IList<Method276> methods { get; set; }
        public IList<Property216> properties { get; set; }
    }

    public class Constructor185
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter274
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method277
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter274> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property217
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class TrackedChangeItem
    {
        public IList<Constructor185> constructors { get; set; }
        public IList<Method277> methods { get; set; }
        public IList<Property217> properties { get; set; }
    }

    public class Constructor186
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter275
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method278
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter275> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property218
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class TrackedChangesCapability
    {
        public IList<Constructor186> constructors { get; set; }
        public IList<Method278> methods { get; set; }
        public IList<Property218> properties { get; set; }
    }

    public class Constructor187
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter276
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method279
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter276> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class UnauthenticatedUser
    {
        public IList<Constructor187> constructors { get; set; }
        public IList<Method279> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor188
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter277
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method280
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter277> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property219
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class UnreadConversationCount
    {
        public IList<Constructor188> constructors { get; set; }
        public IList<Method280> methods { get; set; }
        public IList<Property219> properties { get; set; }
    }

    public class Parameter278
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method281
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter278> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property220
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class CompletionsUser
    {
        public IList<object> constructors { get; set; }
        public IList<Method281> methods { get; set; }
        public IList<Property220> properties { get; set; }
    }

    public class Constructor189
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter279
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method282
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter279> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property221
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class UserCapabilities
    {
        public IList<Constructor189> constructors { get; set; }
        public IList<Method282> methods { get; set; }
        public IList<Property221> properties { get; set; }
    }

    public class Constructor190
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter280
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method283
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter280> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property222
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class UserChatterSettings
    {
        public IList<Constructor190> constructors { get; set; }
        public IList<Method283> methods { get; set; }
        public IList<Property222> properties { get; set; }
    }

    public class Constructor191
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter281
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method284
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter281> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property223
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class UserDetail
    {
        public IList<Constructor191> constructors { get; set; }
        public IList<Method284> methods { get; set; }
        public IList<Property223> properties { get; set; }
    }

    public class Constructor192
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter282
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method285
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter282> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property224
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class UserGroupPage
    {
        public IList<Constructor192> constructors { get; set; }
        public IList<Method285> methods { get; set; }
        public IList<Property224> properties { get; set; }
    }

    public class Constructor193
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter283
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method286
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter283> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property225
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class UserInput
    {
        public IList<Constructor193> constructors { get; set; }
        public IList<Method286> methods { get; set; }
        public IList<Property225> properties { get; set; }
    }

    public class Constructor194
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter284
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method287
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter284> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property226
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class UserPage
    {
        public IList<Constructor194> constructors { get; set; }
        public IList<Method287> methods { get; set; }
        public IList<Property226> properties { get; set; }
    }

    public class Constructor195
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter285
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method288
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter285> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property227
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class UserProfile
    {
        public IList<Constructor195> constructors { get; set; }
        public IList<Method288> methods { get; set; }
        public IList<Property227> properties { get; set; }
    }

    public class Constructor196
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter286
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method289
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter286> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property228
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class UserProfileTab
    {
        public IList<Constructor196> constructors { get; set; }
        public IList<Method289> methods { get; set; }
        public IList<Property228> properties { get; set; }
    }

    public class Parameter287
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method290
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter287> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property229
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class UserProfileTabType
    {
        public IList<object> constructors { get; set; }
        public IList<Method290> methods { get; set; }
        public IList<Property229> properties { get; set; }
    }

    public class Parameter288
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method291
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter288> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class UserProfiles
    {
        public IList<object> constructors { get; set; }
        public IList<Method291> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor197
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter289
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method292
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter289> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property230
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class UserSettings
    {
        public IList<Constructor197> constructors { get; set; }
        public IList<Method292> methods { get; set; }
        public IList<Property230> properties { get; set; }
    }

    public class Constructor198
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter290
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method293
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter290> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property231
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class UserSummary
    {
        public IList<Constructor198> constructors { get; set; }
        public IList<Method293> methods { get; set; }
        public IList<Property231> properties { get; set; }
    }

    public class Parameter291
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method294
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter291> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property232
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class UserType
    {
        public IList<object> constructors { get; set; }
        public IList<Method294> methods { get; set; }
        public IList<Property232> properties { get; set; }
    }

    public class Parameter292
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method295
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter292> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property233
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class WorkflowProcessStatus
    {
        public IList<object> constructors { get; set; }
        public IList<Method295> methods { get; set; }
        public IList<Property233> properties { get; set; }
    }

    public class Constructor199
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter293
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method296
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter293> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property234
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Zone
    {
        public IList<Constructor199> constructors { get; set; }
        public IList<Method296> methods { get; set; }
        public IList<Property234> properties { get; set; }
    }

    public class Constructor200
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter294
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method297
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter294> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property235
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ZonePage
    {
        public IList<Constructor200> constructors { get; set; }
        public IList<Method297> methods { get; set; }
        public IList<Property235> properties { get; set; }
    }

    public class Constructor201
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter295
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method298
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter295> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property236
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ZoneSearchPage
    {
        public IList<Constructor201> constructors { get; set; }
        public IList<Method298> methods { get; set; }
        public IList<Property236> properties { get; set; }
    }

    public class Constructor202
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter296
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method299
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter296> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property237
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ZoneSearchResult
    {
        public IList<Constructor202> constructors { get; set; }
        public IList<Method299> methods { get; set; }
        public IList<Property237> properties { get; set; }
    }

    public class Parameter297
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method300
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter297> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property238
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ZoneSearchResultType
    {
        public IList<object> constructors { get; set; }
        public IList<Method300> methods { get; set; }
        public IList<Property238> properties { get; set; }
    }

    public class Parameter298
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method301
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter298> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property239
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ZoneShowIn
    {
        public IList<object> constructors { get; set; }
        public IList<Method301> methods { get; set; }
        public IList<Property239> properties { get; set; }
    }

    public class Parameter299
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method302
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter299> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Zones
    {
        public IList<object> constructors { get; set; }
        public IList<Method302> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class ConnectApi
    {
        public AbstractMessageBody AbstractMessageBody { get; set; }
        public AbstractRecommendation AbstractRecommendation { get; set; }
        public AbstractRecommendationExplanation AbstractRecommendationExplanation { get; set; }
        public AbstractRecordField AbstractRecordField { get; set; }
        public AbstractRecordView AbstractRecordView { get; set; }
        public Actor Actor { get; set; }
        public ActorWithId ActorWithId { get; set; }
        public Address Address { get; set; }
        public Announcement Announcement { get; set; }
        public AnnouncementInput AnnouncementInput { get; set; }
        public AnnouncementPage AnnouncementPage { get; set; }
        public Announcements Announcements { get; set; }
        public ApprovalAttachment ApprovalAttachment { get; set; }
        public ApprovalCapability ApprovalCapability { get; set; }
        public ApprovalPostTemplateField ApprovalPostTemplateField { get; set; }
        public ArticleItem ArticleItem { get; set; }
        public AssociatedActionsCapability AssociatedActionsCapability { get; set; }
        public BadgeLimitType BadgeLimitType { get; set; }
        public BannerCapability BannerCapability { get; set; }
        public BannerStyle BannerStyle { get; set; }
        public BasicTemplateAttachment BasicTemplateAttachment { get; set; }
        public BatchInput BatchInput { get; set; }
        public BatchResult BatchResult { get; set; }
        public BinaryInput BinaryInput { get; set; }
        public BlankRecordField BlankRecordField { get; set; }
        public BookmarksCapability BookmarksCapability { get; set; }
        public BookmarksCapabilityInput BookmarksCapabilityInput { get; set; }
        public BundleCapability BundleCapability { get; set; }
        public BundleType BundleType { get; set; }
        public CanvasAttachmentInput CanvasAttachmentInput { get; set; }
        public CanvasCapability CanvasCapability { get; set; }
        public CanvasCapabilityInput CanvasCapabilityInput { get; set; }
        public CanvasTemplateAttachment CanvasTemplateAttachment { get; set; }
        public CaseActorType CaseActorType { get; set; }
        public CaseComment CaseComment { get; set; }
        public CaseCommentCapability CaseCommentCapability { get; set; }
        public CaseCommentEventType CaseCommentEventType { get; set; }
        public Chatter Chatter { get; set; }
        public ChatterActivity ChatterActivity { get; set; }
        public ChatterConversation ChatterConversation { get; set; }
        public ChatterConversationPage ChatterConversationPage { get; set; }
        public ChatterConversationSummary ChatterConversationSummary { get; set; }
        public ChatterFavorites ChatterFavorites { get; set; }
        public ChatterFeeds ChatterFeeds { get; set; }
        public ChatterGroup ChatterGroup { get; set; }
        public ChatterGroupDetail ChatterGroupDetail { get; set; }
        public ChatterGroupInput ChatterGroupInput { get; set; }
        public ChatterGroupPage ChatterGroupPage { get; set; }
        public ChatterGroupSummary ChatterGroupSummary { get; set; }
        public ChatterGroups ChatterGroups { get; set; }
        public ChatterLike ChatterLike { get; set; }
        public ChatterLikePage ChatterLikePage { get; set; }
        public ChatterLikesCapability ChatterLikesCapability { get; set; }
        public ChatterMessage ChatterMessage { get; set; }
        public ChatterMessagePage ChatterMessagePage { get; set; }
        public ChatterMessages ChatterMessages { get; set; }
        public ChatterUsers ChatterUsers { get; set; }
        public ClientInfo ClientInfo { get; set; }
        public Comment Comment { get; set; }
        public CommentCapabilities CommentCapabilities { get; set; }
        public CommentCapabilitiesInput CommentCapabilitiesInput { get; set; }
        public CommentInput CommentInput { get; set; }
        public CommentPage CommentPage { get; set; }
        public CommentType CommentType { get; set; }
        public CommentsCapability CommentsCapability { get; set; }
        public Communities Communities { get; set; }
        public Community Community { get; set; }
        public CommunityFlagVisibility CommunityFlagVisibility { get; set; }
        public CommunityModeration CommunityModeration { get; set; }
        public CommunityPage CommunityPage { get; set; }
        public CommunityStatus CommunityStatus { get; set; }
        public ComplexSegment ComplexSegment { get; set; }
        public CompoundRecordField CompoundRecordField { get; set; }
        public ConnectApiException ConnectApiException { get; set; }
        public ContentAttachment ContentAttachment { get; set; }
        public ContentAttachmentInput ContentAttachmentInput { get; set; }
        public ContentCapability ContentCapability { get; set; }
        public ContentCapabilityInput ContentCapabilityInput { get; set; }
        public CurrencyRecordField CurrencyRecordField { get; set; }
        public DashboardComponentAttachment DashboardComponentAttachment { get; set; }
        public DashboardComponentSnapshot DashboardComponentSnapshot { get; set; }
        public DashboardComponentSnapshotCapability DashboardComponentSnapshotCapability { get; set; }
        public Datacloud Datacloud { get; set; }
        public DatacloudCompanies DatacloudCompanies { get; set; }
        public DatacloudCompany DatacloudCompany { get; set; }
        public DatacloudContact DatacloudContact { get; set; }
        public DatacloudContacts DatacloudContacts { get; set; }
        public DatacloudOrder DatacloudOrder { get; set; }
        public DatacloudOrderInput DatacloudOrderInput { get; set; }
        public DatacloudPurchaseUsage DatacloudPurchaseUsage { get; set; }
        public DatacloudUserType DatacloudUserType { get; set; }
        public DateRecordField DateRecordField { get; set; }
        public EmailAddress EmailAddress { get; set; }
        public EmailMessage EmailMessage { get; set; }
        public EmailMessageCapability EmailMessageCapability { get; set; }
        public EmailMessageDirection EmailMessageDirection { get; set; }
        public EnhancedLinkCapability EnhancedLinkCapability { get; set; }
        public EntityLinkSegment EntityLinkSegment { get; set; }
        public EntityRecommendation EntityRecommendation { get; set; }
        public Features Features { get; set; }
        public Feed Feed { get; set; }
        public FeedBody FeedBody { get; set; }
        public FeedDensity FeedDensity { get; set; }
        public FeedDirectory FeedDirectory { get; set; }
        public FeedDirectoryItem FeedDirectoryItem { get; set; }
        public FeedElement FeedElement { get; set; }
        public FeedElementCapabilities FeedElementCapabilities { get; set; }
        public FeedElementCapabilitiesInput FeedElementCapabilitiesInput { get; set; }
        public FeedElementCapability FeedElementCapability { get; set; }
        public FeedElementCapabilityInput FeedElementCapabilityInput { get; set; }
        public FeedElementCapabilityType FeedElementCapabilityType { get; set; }
        public FeedElementInput FeedElementInput { get; set; }
        public FeedElementPage FeedElementPage { get; set; }
        public FeedElementType FeedElementType { get; set; }
        public FeedFavorite FeedFavorite { get; set; }
        public FeedFavoriteType FeedFavoriteType { get; set; }
        public FeedFavorites FeedFavorites { get; set; }
        public FeedFilter FeedFilter { get; set; }
        public FeedItem FeedItem { get; set; }
        public FeedItemAttachment FeedItemAttachment { get; set; }
        public FeedItemAttachmentInput FeedItemAttachmentInput { get; set; }
        public FeedItemAttachmentType FeedItemAttachmentType { get; set; }
        public FeedItemInput FeedItemInput { get; set; }
        public FeedItemPage FeedItemPage { get; set; }
        public FeedItemTopicPage FeedItemTopicPage { get; set; }
        public FeedItemType FeedItemType { get; set; }
        public FeedItemVisibilityType FeedItemVisibilityType { get; set; }
        public FeedModifiedInfo FeedModifiedInfo { get; set; }
        public FeedPoll FeedPoll { get; set; }
        public FeedPollChoice FeedPollChoice { get; set; }
        public FeedSortOrder FeedSortOrder { get; set; }
        public FeedType FeedType { get; set; }
        public FieldChangeNameSegment FieldChangeNameSegment { get; set; }
        public FieldChangeSegment FieldChangeSegment { get; set; }
        public FieldChangeValueSegment FieldChangeValueSegment { get; set; }
        public FieldChangeValueType FieldChangeValueType { get; set; }
        public File File { get; set; }
        public FilePublishStatus FilePublishStatus { get; set; }
        public FileSharingType FileSharingType { get; set; }
        public FileSummary FileSummary { get; set; }
        public FollowerPage FollowerPage { get; set; }
        public FollowingCounts FollowingCounts { get; set; }
        public FollowingPage FollowingPage { get; set; }
        public GenericBundleCapability GenericBundleCapability { get; set; }
        public GenericFeedElement GenericFeedElement { get; set; }
        public GlobalInfluence GlobalInfluence { get; set; }
        public GroupArchiveStatus GroupArchiveStatus { get; set; }
        public GroupChatterSettings GroupChatterSettings { get; set; }
        public GroupEmailFrequency GroupEmailFrequency { get; set; }
        public GroupInformation GroupInformation { get; set; }
        public GroupInformationInput GroupInformationInput { get; set; }
        public GroupMember GroupMember { get; set; }
        public GroupMemberPage GroupMemberPage { get; set; }
        public GroupMembershipRequest GroupMembershipRequest { get; set; }
        public GroupMembershipRequestStatus GroupMembershipRequestStatus { get; set; }
        public GroupMembershipRequests GroupMembershipRequests { get; set; }
        public GroupMembershipType GroupMembershipType { get; set; }
        public GroupRecord GroupRecord { get; set; }
        public GroupRecordPage GroupRecordPage { get; set; }
        public GroupVisibilityType GroupVisibilityType { get; set; }
        public HashtagSegment HashtagSegment { get; set; }
        public HashtagSegmentInput HashtagSegmentInput { get; set; }
        public Icon Icon { get; set; }
        public LabeledRecordField LabeledRecordField { get; set; }
        public LinkAttachment LinkAttachment { get; set; }
        public LinkAttachmentInput LinkAttachmentInput { get; set; }
        public LinkCapability LinkCapability { get; set; }
        public LinkCapabilityInput LinkCapabilityInput { get; set; }
        public LinkSegment LinkSegment { get; set; }
        public LinkSegmentInput LinkSegmentInput { get; set; }
        public ManagedTopic ManagedTopic { get; set; }
        public ManagedTopicCollection ManagedTopicCollection { get; set; }
        public ManagedTopicPositionCollectionInput ManagedTopicPositionCollectionInput { get; set; }
        public ManagedTopicPositionInput ManagedTopicPositionInput { get; set; }
        public ManagedTopicType ManagedTopicType { get; set; }
        public ManagedTopics ManagedTopics { get; set; }
        public MentionCompletion MentionCompletion { get; set; }
        public MentionCompletionPage MentionCompletionPage { get; set; }
        public MentionCompletionType MentionCompletionType { get; set; }
        public MentionSegment MentionSegment { get; set; }
        public MentionSegmentInput MentionSegmentInput { get; set; }
        public MentionValidation MentionValidation { get; set; }
        public MentionValidationStatus MentionValidationStatus { get; set; }
        public MentionValidations MentionValidations { get; set; }
        public Mentions Mentions { get; set; }
        public MessageBody MessageBody { get; set; }
        public MessageBodyInput MessageBodyInput { get; set; }
        public MessageSegment MessageSegment { get; set; }
        public MessageSegmentInput MessageSegmentInput { get; set; }
        public MessageSegmentType MessageSegmentType { get; set; }
        public ModerationCapability ModerationCapability { get; set; }
        public ModerationFlags ModerationFlags { get; set; }
        public MoreChangesSegment MoreChangesSegment { get; set; }
        public Motif Motif { get; set; }
        public NewFileAttachmentInput NewFileAttachmentInput { get; set; }
        public NonEntityRecommendation NonEntityRecommendation { get; set; }
        public NotFoundException NotFoundException { get; set; }
        public Organization Organization { get; set; }
        public OrganizationSettings OrganizationSettings { get; set; }
        public PercentRecordField PercentRecordField { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public Photo Photo { get; set; }
        public PhotoInput PhotoInput { get; set; }
        public PicklistRecordField PicklistRecordField { get; set; }
        public PollAttachmentInput PollAttachmentInput { get; set; }
        public PollCapability PollCapability { get; set; }
        public PollCapabilityInput PollCapabilityInput { get; set; }
        public QuestionAndAnswers QuestionAndAnswers { get; set; }
        public QuestionAndAnswersCapability QuestionAndAnswersCapability { get; set; }
        public QuestionAndAnswersCapabilityInput QuestionAndAnswersCapabilityInput { get; set; }
        public QuestionAndAnswersSuggestions QuestionAndAnswersSuggestions { get; set; }
        public QuestionAttachment QuestionAttachment { get; set; }
        public QuestionAttachmentInput QuestionAttachmentInput { get; set; }
        public RateLimitException RateLimitException { get; set; }
        public RecommendationActionType RecommendationActionType { get; set; }
        public RecommendationExplanation RecommendationExplanation { get; set; }
        public RecommendationExplanationType RecommendationExplanationType { get; set; }
        public RecommendationType RecommendationType { get; set; }
        public RecommendationsCapability RecommendationsCapability { get; set; }
        public RecordColumnOrder RecordColumnOrder { get; set; }
        public RecordDetails RecordDetails { get; set; }
        public RecordField RecordField { get; set; }
        public RecordFieldType RecordFieldType { get; set; }
        public RecordSnapshotAttachment RecordSnapshotAttachment { get; set; }
        public RecordSnapshotCapability RecordSnapshotCapability { get; set; }
        public RecordSummary RecordSummary { get; set; }
        public RecordSummaryList RecordSummaryList { get; set; }
        public RecordView RecordView { get; set; }
        public RecordViewSection RecordViewSection { get; set; }
        public Records Records { get; set; }
        public Reference Reference { get; set; }
        public ReferenceRecordField ReferenceRecordField { get; set; }
        public ReferenceWithDateRecordField ReferenceWithDateRecordField { get; set; }
        public Reputation Reputation { get; set; }
        public ReputationLevel ReputationLevel { get; set; }
        public ResourceLinkSegment ResourceLinkSegment { get; set; }
        public SortOrder SortOrder { get; set; }
        public Subscription Subscription { get; set; }
        public TextSegment TextSegment { get; set; }
        public TextSegmentInput TextSegmentInput { get; set; }
        public TimeZone TimeZone { get; set; }
        public Topic Topic { get; set; }
        public TopicImages TopicImages { get; set; }
        public TopicInput TopicInput { get; set; }
        public TopicPage TopicPage { get; set; }
        public TopicSort TopicSort { get; set; }
        public TopicSuggestion TopicSuggestion { get; set; }
        public TopicSuggestionPage TopicSuggestionPage { get; set; }
        public Topics Topics { get; set; }
        public TopicsCapability TopicsCapability { get; set; }
        public TrackedChangeAttachment TrackedChangeAttachment { get; set; }
        public TrackedChangeBundleCapability TrackedChangeBundleCapability { get; set; }
        public TrackedChangeItem TrackedChangeItem { get; set; }
        public TrackedChangesCapability TrackedChangesCapability { get; set; }
        public UnauthenticatedUser UnauthenticatedUser { get; set; }
        public UnreadConversationCount UnreadConversationCount { get; set; }
        public CompletionsUser User { get; set; }
        public UserCapabilities UserCapabilities { get; set; }
        public UserChatterSettings UserChatterSettings { get; set; }
        public UserDetail UserDetail { get; set; }
        public UserGroupPage UserGroupPage { get; set; }
        public UserInput UserInput { get; set; }
        public UserPage UserPage { get; set; }
        public UserProfile UserProfile { get; set; }
        public UserProfileTab UserProfileTab { get; set; }
        public UserProfileTabType UserProfileTabType { get; set; }
        public UserProfiles UserProfiles { get; set; }
        public UserSettings UserSettings { get; set; }
        public UserSummary UserSummary { get; set; }
        public UserType UserType { get; set; }
        public WorkflowProcessStatus WorkflowProcessStatus { get; set; }
        public Zone Zone { get; set; }
        public ZonePage ZonePage { get; set; }
        public ZoneSearchPage ZoneSearchPage { get; set; }
        public ZoneSearchResult ZoneSearchResult { get; set; }
        public ZoneSearchResultType ZoneSearchResultType { get; set; }
        public ZoneShowIn ZoneShowIn { get; set; }
        public Zones Zones { get; set; }
    }

    public class Constructor203
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Property240
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class AssignmentRuleHeader
    {
        public IList<Constructor203> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property240> properties { get; set; }
    }

    public class Parameter300
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method303
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter300> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Batchable
    {
        public IList<object> constructors { get; set; }
        public IList<Method303> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method304
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class BatchableContext
    {
        public IList<object> constructors { get; set; }
        public IList<Method304> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method305
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class BatchableContextImpl
    {
        public IList<object> constructors { get; set; }
        public IList<Method305> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor204
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Property241
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class DMLOptions
    {
        public IList<Constructor204> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property241> properties { get; set; }
    }

    public class Method306
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DeleteResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method306> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method307
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DeletedRecord
    {
        public IList<object> constructors { get; set; }
        public IList<Method307> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor205
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Property242
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class EmailHeader
    {
        public IList<Constructor205> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property242> properties { get; set; }
    }

    public class Method308
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class EmptyRecycleBinResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method308> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method309
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Error
    {
        public IList<object> constructors { get; set; }
        public IList<Method309> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method310
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class GetDeletedResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method310> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method311
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class GetUpdatedResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method311> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor206
    {
        public object name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter301
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method312
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter301> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class LeadConvert
    {
        public IList<Constructor206> constructors { get; set; }
        public IList<Method312> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method313
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class LeadConvertResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method313> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor207
    {
        public object name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter302
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method314
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter302> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class MergeRequest
    {
        public IList<Constructor207> constructors { get; set; }
        public IList<Method314> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method315
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class MergeResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method315> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method316
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class QueryLocator
    {
        public IList<object> constructors { get; set; }
        public IList<Method316> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method317
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class QueryLocatorChunkIterator
    {
        public IList<object> constructors { get; set; }
        public IList<Method317> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method318
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class QueryLocatorIterator
    {
        public IList<object> constructors { get; set; }
        public IList<Method318> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method319
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SaveResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method319> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method320
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class UndeleteResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method320> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method321
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class UpsertResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method321> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Database
    {
        public AssignmentRuleHeader AssignmentRuleHeader { get; set; }
        public Batchable Batchable { get; set; }
        public BatchableContext BatchableContext { get; set; }
        public BatchableContextImpl BatchableContextImpl { get; set; }
        public DMLOptions DMLOptions { get; set; }
        public DeleteResult DeleteResult { get; set; }
        public DeletedRecord DeletedRecord { get; set; }
        public EmailHeader EmailHeader { get; set; }
        public EmptyRecycleBinResult EmptyRecycleBinResult { get; set; }
        public Error Error { get; set; }
        public GetDeletedResult GetDeletedResult { get; set; }
        public GetUpdatedResult GetUpdatedResult { get; set; }
        public LeadConvert LeadConvert { get; set; }
        public LeadConvertResult LeadConvertResult { get; set; }
        public MergeRequest MergeRequest { get; set; }
        public MergeResult MergeResult { get; set; }
        public QueryLocator QueryLocator { get; set; }
        public QueryLocatorChunkIterator QueryLocatorChunkIterator { get; set; }
        public QueryLocatorIterator QueryLocatorIterator { get; set; }
        public SaveResult SaveResult { get; set; }
        public UndeleteResult UndeleteResult { get; set; }
        public UpsertResult UpsertResult { get; set; }
    }

    public class Parameter303
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method322
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter303> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Interview
    {
        public IList<object> constructors { get; set; }
        public IList<Method322> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Flow
    {
        public Interview Interview { get; set; }
    }

    public class Constructor208
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter304
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method323
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter304> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class PublishingService
    {
        public IList<Constructor208> constructors { get; set; }
        public IList<Method323> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class KbManagement
    {
        public PublishingService PublishingService { get; set; }
    }

    public class Constructor209
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter305
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method324
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter305> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class LiveAgentRealTimeSystem
    {
        public IList<Constructor209> constructors { get; set; }
        public IList<Method324> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter306
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method325
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter306> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class LiveChatRouter
    {
        public IList<object> constructors { get; set; }
        public IList<Method325> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter307
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor210
    {
        public string name { get; set; }
        public IList<Parameter307> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method326
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class LiveChatRoutingRequest
    {
        public IList<Constructor210> constructors { get; set; }
        public IList<Method326> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method327
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class LiveChatRoutingResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method327> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter308
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method328
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter308> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property243
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class LiveChatRoutingResultType
    {
        public IList<object> constructors { get; set; }
        public IList<Method328> methods { get; set; }
        public IList<Property243> properties { get; set; }
    }

    public class Parameter309
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor211
    {
        public string name { get; set; }
        public IList<Parameter309> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method329
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class LiveChatRoutingRoute
    {
        public IList<Constructor211> constructors { get; set; }
        public IList<Method329> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class LiveAgent
    {
        public LiveAgentRealTimeSystem LiveAgentRealTimeSystem { get; set; }
        public LiveChatRouter LiveChatRouter { get; set; }
        public LiveChatRoutingRequest LiveChatRoutingRequest { get; set; }
        public LiveChatRoutingResult LiveChatRoutingResult { get; set; }
        public LiveChatRoutingResultType LiveChatRoutingResultType { get; set; }
        public LiveChatRoutingRoute LiveChatRoutingRoute { get; set; }
    }

    public class Constructor212
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Property244
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class BinaryAttachment
    {
        public IList<Constructor212> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property244> properties { get; set; }
    }

    public class Parameter310
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method330
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter310> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Email
    {
        public IList<object> constructors { get; set; }
        public IList<Method330> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor213
    {
        public object name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter311
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method331
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter311> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class EmailAttachment
    {
        public IList<Constructor213> constructors { get; set; }
        public IList<Method331> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor214
    {
        public object name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter312
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method332
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter312> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class EmailFileAttachment
    {
        public IList<Constructor214> constructors { get; set; }
        public IList<Method332> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor215
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class EmailToSalesforceHandler
    {
        public IList<Constructor215> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor216
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Property245
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Header
    {
        public IList<Constructor216> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property245> properties { get; set; }
    }

    public class Constructor217
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Property246
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class InboundEmail
    {
        public IList<Constructor217> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property246> properties { get; set; }
    }

    public class Parameter313
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method333
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter313> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class InboundEmailHandler
    {
        public IList<object> constructors { get; set; }
        public IList<Method333> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor218
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Property247
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class InboundEmailResult
    {
        public IList<Constructor218> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property247> properties { get; set; }
    }

    public class Constructor219
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Property248
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class InboundEnvelope
    {
        public IList<Constructor219> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property248> properties { get; set; }
    }

    public class Constructor220
    {
        public object name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter314
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method334
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter314> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class MassEmailMessage
    {
        public IList<Constructor220> constructors { get; set; }
        public IList<Method334> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter315
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor221
    {
        public string name { get; set; }
        public IList<Parameter315> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter316
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method335
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter316> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class PushNotification
    {
        public IList<Constructor221> constructors { get; set; }
        public IList<Method335> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor222
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter317
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method336
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter317> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class PushNotificationPayload
    {
        public IList<Constructor222> constructors { get; set; }
        public IList<Method336> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method337
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SendEmailError
    {
        public IList<object> constructors { get; set; }
        public IList<Method337> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method338
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SendEmailResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method338> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor223
    {
        public object name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter318
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method339
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter318> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SingleEmailMessage
    {
        public IList<Constructor223> constructors { get; set; }
        public IList<Method339> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor224
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Property249
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class TextAttachment
    {
        public IList<Constructor224> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property249> properties { get; set; }
    }

    public class Messaging
    {
        public BinaryAttachment BinaryAttachment { get; set; }
        public Email Email { get; set; }
        public EmailAttachment EmailAttachment { get; set; }
        public EmailFileAttachment EmailFileAttachment { get; set; }
        public EmailToSalesforceHandler EmailToSalesforceHandler { get; set; }
        public Header Header { get; set; }
        public InboundEmail InboundEmail { get; set; }
        public InboundEmailHandler InboundEmailHandler { get; set; }
        public InboundEmailResult InboundEmailResult { get; set; }
        public InboundEnvelope InboundEnvelope { get; set; }
        public MassEmailMessage MassEmailMessage { get; set; }
        public PushNotification PushNotification { get; set; }
        public PushNotificationPayload PushNotificationPayload { get; set; }
        public SendEmailError SendEmailError { get; set; }
        public SendEmailResult SendEmailResult { get; set; }
        public SingleEmailMessage SingleEmailMessage { get; set; }
        public TextAttachment TextAttachment { get; set; }
    }

    public class Parameter319
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor225
    {
        public string name { get; set; }
        public IList<Parameter319> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Property250
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class InputParameter
    {
        public IList<Constructor225> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property250> properties { get; set; }
    }

    public class Parameter320
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor226
    {
        public string name { get; set; }
        public IList<Parameter320> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Property251
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class OutputParameter
    {
        public IList<Constructor226> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property251> properties { get; set; }
    }

    public class Parameter321
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method340
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter321> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property252
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ParameterType
    {
        public IList<object> constructors { get; set; }
        public IList<Method340> methods { get; set; }
        public IList<Property252> properties { get; set; }
    }

    public class Parameter322
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method341
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter322> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Plugin
    {
        public IList<object> constructors { get; set; }
        public IList<Method341> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor227
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Property253
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class PluginDescribeResult
    {
        public IList<Constructor227> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property253> properties { get; set; }
    }

    public class Parameter323
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor228
    {
        public string name { get; set; }
        public IList<Parameter323> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Property254
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class PluginRequest
    {
        public IList<Constructor228> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property254> properties { get; set; }
    }

    public class Parameter324
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor229
    {
        public string name { get; set; }
        public IList<Parameter324> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Property255
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class PluginResult
    {
        public IList<Constructor229> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property255> properties { get; set; }
    }

    public class Constructor230
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter325
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method342
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter325> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SparkPlugApi
    {
        public IList<Constructor230> constructors { get; set; }
        public IList<Method342> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor231
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Property256
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class SparkPlugDescribeResult
    {
        public IList<Constructor231> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property256> properties { get; set; }
    }

    public class Constructor232
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Property257
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class SparkPlugParameter
    {
        public IList<Constructor232> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property257> properties { get; set; }
    }

    public class Process
    {
        public InputParameter InputParameter { get; set; }
        public OutputParameter OutputParameter { get; set; }
        public ParameterType ParameterType { get; set; }
        public Plugin Plugin { get; set; }
        public PluginDescribeResult PluginDescribeResult { get; set; }
        public PluginRequest PluginRequest { get; set; }
        public PluginResult PluginResult { get; set; }
        public SparkPlugApi SparkPlugApi { get; set; }
        public SparkPlugDescribeResult SparkPlugDescribeResult { get; set; }
        public SparkPlugParameter SparkPlugParameter { get; set; }
    }

    public class Method343
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Control
    {
        public IList<object> constructors { get; set; }
        public IList<Method343> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method344
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DescribeAvailableQuickActionResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method344> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method345
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DescribeLayoutComponent
    {
        public IList<object> constructors { get; set; }
        public IList<Method345> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method346
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DescribeLayoutItem
    {
        public IList<object> constructors { get; set; }
        public IList<Method346> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method347
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DescribeLayoutRow
    {
        public IList<object> constructors { get; set; }
        public IList<Method347> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method348
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DescribeLayoutSection
    {
        public IList<object> constructors { get; set; }
        public IList<Method348> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method349
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DescribeQuickActionDefaultValue
    {
        public IList<object> constructors { get; set; }
        public IList<Method349> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method350
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DescribeQuickActionResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method350> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method351
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class EmptySpace
    {
        public IList<object> constructors { get; set; }
        public IList<Method351> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method352
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ExpandedLookup
    {
        public IList<object> constructors { get; set; }
        public IList<Method352> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method353
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Field
    {
        public IList<object> constructors { get; set; }
        public IList<Method353> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method354
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class FieldLayoutComponent
    {
        public IList<object> constructors { get; set; }
        public IList<Method354> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor233
    {
        public object name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter326
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method355
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter326> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class QuickActionRequest
    {
        public IList<Constructor233> constructors { get; set; }
        public IList<Method355> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method356
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class QuickActionResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method356> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method357
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class QuickActionTemplateResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method357> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method358
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportChartComponent
    {
        public IList<object> constructors { get; set; }
        public IList<Method358> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method359
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SControl
    {
        public IList<object> constructors { get; set; }
        public IList<Method359> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method360
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Separator
    {
        public IList<object> constructors { get; set; }
        public IList<Method360> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method361
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class VisualforcePage
    {
        public IList<object> constructors { get; set; }
        public IList<Method361> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class QuickAction
    {
        public Control Control { get; set; }
        public DescribeAvailableQuickActionResult DescribeAvailableQuickActionResult { get; set; }
        public DescribeLayoutComponent DescribeLayoutComponent { get; set; }
        public DescribeLayoutItem DescribeLayoutItem { get; set; }
        public DescribeLayoutRow DescribeLayoutRow { get; set; }
        public DescribeLayoutSection DescribeLayoutSection { get; set; }
        public DescribeQuickActionDefaultValue DescribeQuickActionDefaultValue { get; set; }
        public DescribeQuickActionResult DescribeQuickActionResult { get; set; }
        public EmptySpace EmptySpace { get; set; }
        public ExpandedLookup ExpandedLookup { get; set; }
        public Field Field { get; set; }
        public FieldLayoutComponent FieldLayoutComponent { get; set; }
        public QuickActionRequest QuickActionRequest { get; set; }
        public QuickActionResult QuickActionResult { get; set; }
        public QuickActionTemplateResult QuickActionTemplateResult { get; set; }
        public ReportChartComponent ReportChartComponent { get; set; }
        public SControl SControl { get; set; }
        public Separator Separator { get; set; }
        public VisualforcePage VisualforcePage { get; set; }
    }

    public class Method362
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ChildRelationship
    {
        public IList<object> constructors { get; set; }
        public IList<Method362> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method363
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DataCategory
    {
        public IList<object> constructors { get; set; }
        public IList<Method363> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor234
    {
        public object name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter327
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method364
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter327> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DataCategoryGroupSobjectTypePair
    {
        public IList<Constructor234> constructors { get; set; }
        public IList<Method364> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method365
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DescribeColorResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method365> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method366
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DescribeDataCategoryGroupResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method366> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method367
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DescribeDataCategoryGroupStructureResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method367> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method368
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DescribeFieldResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method368> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method369
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DescribeIconResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method369> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method370
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DescribeSObjectResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method370> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method371
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DescribeTabResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method371> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method372
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DescribeTabSetResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method372> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter328
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method373
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter328> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property258
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class DisplayType
    {
        public IList<object> constructors { get; set; }
        public IList<Method373> methods { get; set; }
        public IList<Property258> properties { get; set; }
    }

    public class Method374
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class FieldSet
    {
        public IList<object> constructors { get; set; }
        public IList<Method374> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method375
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class FieldSetMember
    {
        public IList<object> constructors { get; set; }
        public IList<Method375> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method376
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class FilteredLookupInfo
    {
        public IList<object> constructors { get; set; }
        public IList<Method376> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method377
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class PicklistEntry
    {
        public IList<object> constructors { get; set; }
        public IList<Method377> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method378
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class RecordTypeInfo
    {
        public IList<object> constructors { get; set; }
        public IList<Method378> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method379
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SObjectField
    {
        public IList<object> constructors { get; set; }
        public IList<Method379> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter329
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method380
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter329> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SObjectType
    {
        public IList<object> constructors { get; set; }
        public IList<Method380> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter330
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method381
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter330> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property259
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class SoapType
    {
        public IList<object> constructors { get; set; }
        public IList<Method381> methods { get; set; }
        public IList<Property259> properties { get; set; }
    }

    public class Schema
    {
        public ChildRelationship ChildRelationship { get; set; }
        public DataCategory DataCategory { get; set; }
        public DataCategoryGroupSobjectTypePair DataCategoryGroupSobjectTypePair { get; set; }
        public DescribeColorResult DescribeColorResult { get; set; }
        public DescribeDataCategoryGroupResult DescribeDataCategoryGroupResult { get; set; }
        public DescribeDataCategoryGroupStructureResult DescribeDataCategoryGroupStructureResult { get; set; }
        public DescribeFieldResult DescribeFieldResult { get; set; }
        public DescribeIconResult DescribeIconResult { get; set; }
        public DescribeSObjectResult DescribeSObjectResult { get; set; }
        public DescribeTabResult DescribeTabResult { get; set; }
        public DescribeTabSetResult DescribeTabSetResult { get; set; }
        public DisplayType DisplayType { get; set; }
        public FieldSet FieldSet { get; set; }
        public FieldSetMember FieldSetMember { get; set; }
        public FilteredLookupInfo FilteredLookupInfo { get; set; }
        public PicklistEntry PicklistEntry { get; set; }
        public RecordTypeInfo RecordTypeInfo { get; set; }
        public SObjectField SObjectField { get; set; }
        public SObjectType SObjectType { get; set; }
        public SoapType SoapType { get; set; }
    }

    public class Parameter331
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method382
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter331> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class UrlRewriter
    {
        public IList<object> constructors { get; set; }
        public IList<Method382> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Site
    {
        public UrlRewriter UrlRewriter { get; set; }
    }

    public class Parameter332
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method383
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter332> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class InboundSocialPostHandler
    {
        public IList<object> constructors { get; set; }
        public IList<Method383> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor235
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter333
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method384
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter333> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class InboundSocialPostHandlerImpl
    {
        public IList<Constructor235> constructors { get; set; }
        public IList<Method384> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor236
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter334
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method385
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter334> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class InboundSocialPostResult
    {
        public IList<Constructor236> constructors { get; set; }
        public IList<Method385> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Social
    {
        public InboundSocialPostHandler InboundSocialPostHandler { get; set; }
        public InboundSocialPostHandlerImpl InboundSocialPostHandlerImpl { get; set; }
        public InboundSocialPostResult InboundSocialPostResult { get; set; }
    }

    public class Parameter335
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method386
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter335> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class EmailTemplateSelector
    {
        public IList<object> constructors { get; set; }
        public IList<Method386> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor237
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class EmailToCaseHandler
    {
        public IList<Constructor237> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter336
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method387
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter336> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class MilestoneTriggerTimeCalculator
    {
        public IList<object> constructors { get; set; }
        public IList<Method387> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Support
    {
        public EmailTemplateSelector EmailTemplateSelector { get; set; }
        public EmailToCaseHandler EmailToCaseHandler { get; set; }
        public MilestoneTriggerTimeCalculator MilestoneTriggerTimeCalculator { get; set; }
    }

    public class Constructor238
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter337
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method388
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter337> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Answers
    {
        public IList<Constructor238> constructors { get; set; }
        public IList<Method388> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter338
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method389
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter338> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ApexPages2
    {
        public IList<object> constructors { get; set; }
        public IList<Method389> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor239
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter339
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method390
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter339> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class AppExchange
    {
        public IList<Constructor239> constructors { get; set; }
        public IList<Method390> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter340
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method391
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter340> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property260
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ApplicationReadWriteMode
    {
        public IList<object> constructors { get; set; }
        public IList<Method391> methods { get; set; }
        public IList<Property260> properties { get; set; }
    }

    public class Parameter341
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method392
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter341> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class AssertException
    {
        public IList<object> constructors { get; set; }
        public IList<Method392> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter342
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method393
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter342> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class AsyncException
    {
        public IList<object> constructors { get; set; }
        public IList<Method393> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter343
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method394
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter343> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Blob
    {
        public IList<object> constructors { get; set; }
        public IList<Method394> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter344
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method395
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter344> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Boolean
    {
        public IList<object> constructors { get; set; }
        public IList<Method395> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor240
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter345
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method396
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter345> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class BusinessHours
    {
        public IList<Constructor240> constructors { get; set; }
        public IList<Method396> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter346
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method397
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter346> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class CURRENCY
    {
        public IList<object> constructors { get; set; }
        public IList<Method397> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter347
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method398
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter347> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class CalloutException
    {
        public IList<object> constructors { get; set; }
        public IList<Method398> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter348
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method399
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter348> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class CanvasException
    {
        public IList<object> constructors { get; set; }
        public IList<Method399> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor241
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter349
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method400
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter349> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Cases
    {
        public IList<Constructor241> constructors { get; set; }
        public IList<Method400> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter350
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor242
    {
        public string name { get; set; }
        public IList<Parameter350> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter351
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method401
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter351> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class CollectSimilarCasesData
    {
        public IList<Constructor242> constructors { get; set; }
        public IList<Method401> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor243
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter352
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method402
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter352> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Communities2
    {
        public IList<Constructor243> constructors { get; set; }
        public IList<Method402> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter353
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method403
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter353> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Comparable
    {
        public IList<object> constructors { get; set; }
        public IList<Method403> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter354
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor244
    {
        public string name { get; set; }
        public IList<Parameter354> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter355
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method404
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter355> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property261
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Continuation
    {
        public IList<Constructor244> constructors { get; set; }
        public IList<Method404> methods { get; set; }
        public IList<Property261> properties { get; set; }
    }

    public class Parameter356
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor245
    {
        public object name { get; set; }
        public IList<Parameter356> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method405
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Cookie
    {
        public IList<Constructor245> constructors { get; set; }
        public IList<Method405> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor246
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter357
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method406
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter357> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Crypto
    {
        public IList<Constructor246> constructors { get; set; }
        public IList<Method406> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter358
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method407
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter358> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Database2
    {
        public IList<object> constructors { get; set; }
        public IList<Method407> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter359
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method408
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter359> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Date
    {
        public IList<object> constructors { get; set; }
        public IList<Method408> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter360
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method409
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter360> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Datetime
    {
        public IList<object> constructors { get; set; }
        public IList<Method409> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter361
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method410
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter361> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Decimal
    {
        public IList<object> constructors { get; set; }
        public IList<Method410> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter362
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method411
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter362> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DmlException
    {
        public IList<object> constructors { get; set; }
        public IList<Method411> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter363
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method412
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter363> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Double
    {
        public IList<object> constructors { get; set; }
        public IList<Method412> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter364
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method413
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter364> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class EmailException
    {
        public IList<object> constructors { get; set; }
        public IList<Method413> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor247
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter365
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method414
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter365> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class EncodingUtil
    {
        public IList<Constructor247> constructors { get; set; }
        public IList<Method414> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter366
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method415
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter366> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Exception
    {
        public IList<object> constructors { get; set; }
        public IList<Method415> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor248
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter367
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method416
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter367> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class FfxPortalData
    {
        public IList<Constructor248> constructors { get; set; }
        public IList<Method416> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter368
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method417
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter368> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class FinalException
    {
        public IList<object> constructors { get; set; }
        public IList<Method417> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter369
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method418
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter369> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class FlowException
    {
        public IList<object> constructors { get; set; }
        public IList<Method418> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter370
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method419
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter370> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class HandledException
    {
        public IList<object> constructors { get; set; }
        public IList<Method419> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor249
    {
        public object name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter371
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method420
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter371> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Http
    {
        public IList<Constructor249> constructors { get; set; }
        public IList<Method420> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter372
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method421
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter372> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class HttpCalloutMock
    {
        public IList<object> constructors { get; set; }
        public IList<Method421> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor250
    {
        public object name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter373
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method422
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter373> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class HttpRequest
    {
        public IList<Constructor250> constructors { get; set; }
        public IList<Method422> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor251
    {
        public object name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter374
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method423
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter374> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class HttpResponse
    {
        public IList<Constructor251> constructors { get; set; }
        public IList<Method423> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter375
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method424
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter375> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Id
    {
        public IList<object> constructors { get; set; }
        public IList<Method424> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor252
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter376
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method425
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter376> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Ideas
    {
        public IList<Constructor252> constructors { get; set; }
        public IList<Method425> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter377
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method426
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter377> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Integer
    {
        public IList<object> constructors { get; set; }
        public IList<Method426> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter378
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor253
    {
        public string name { get; set; }
        public IList<Parameter378> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method427
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class InvalidHeaderException
    {
        public IList<Constructor253> constructors { get; set; }
        public IList<Method427> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter379
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor254
    {
        public object name { get; set; }
        public IList<Parameter379> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter380
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method428
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter380> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class InvalidParameterValueException
    {
        public IList<Constructor254> constructors { get; set; }
        public IList<Method428> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter381
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method429
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter381> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class InvalidReadOnlyUserDmlException
    {
        public IList<object> constructors { get; set; }
        public IList<Method429> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method430
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Iterable
    {
        public IList<object> constructors { get; set; }
        public IList<Method430> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method431
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Iterator
    {
        public IList<object> constructors { get; set; }
        public IList<Method431> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor255
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter382
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method432
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter382> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class JSON
    {
        public IList<Constructor255> constructors { get; set; }
        public IList<Method432> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter383
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method433
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter383> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class JSONException
    {
        public IList<object> constructors { get; set; }
        public IList<Method433> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter384
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method434
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter384> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class JSONGenerator
    {
        public IList<object> constructors { get; set; }
        public IList<Method434> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter385
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method435
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter385> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class JSONParser
    {
        public IList<object> constructors { get; set; }
        public IList<Method435> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter386
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method436
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter386> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property262
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class JSONToken
    {
        public IList<object> constructors { get; set; }
        public IList<Method436> methods { get; set; }
        public IList<Property262> properties { get; set; }
    }

    public class Parameter387
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method437
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter387> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class LIST
    {
        public IList<object> constructors { get; set; }
        public IList<Method437> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter388
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method438
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter388> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class LicenseException
    {
        public IList<object> constructors { get; set; }
        public IList<Method438> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter389
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method439
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter389> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class LimitException
    {
        public IList<object> constructors { get; set; }
        public IList<Method439> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter390
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method440
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter390> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ListException
    {
        public IList<object> constructors { get; set; }
        public IList<Method440> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter391
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method441
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter391> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property263
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class LoggingLevel
    {
        public IList<object> constructors { get; set; }
        public IList<Method441> methods { get; set; }
        public IList<Property263> properties { get; set; }
    }

    public class Parameter392
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method442
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter392> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Long
    {
        public IList<object> constructors { get; set; }
        public IList<Method442> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter393
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method443
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter393> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Map
    {
        public IList<object> constructors { get; set; }
        public IList<Method443> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter394
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method444
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter394> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Matcher
    {
        public IList<object> constructors { get; set; }
        public IList<Method444> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor256
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter395
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method445
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter395> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property264
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Math
    {
        public IList<Constructor256> constructors { get; set; }
        public IList<Method445> methods { get; set; }
        public IList<Property264> properties { get; set; }
    }

    public class Parameter396
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method446
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter396> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class MathException
    {
        public IList<object> constructors { get; set; }
        public IList<Method446> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter397
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method447
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter397> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Messaging2
    {
        public IList<object> constructors { get; set; }
        public IList<Method447> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor257
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter398
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method448
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter398> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class MultiStaticResourceCalloutMock
    {
        public IList<Constructor257> constructors { get; set; }
        public IList<Method448> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor258
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter399
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method449
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter399> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Network
    {
        public IList<Constructor258> constructors { get; set; }
        public IList<Method449> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor259
    {
        public object name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter400
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method450
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter400> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class NoAccessException
    {
        public IList<Constructor259> constructors { get; set; }
        public IList<Method450> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor260
    {
        public object name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter401
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method451
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter401> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class NoDataFoundException
    {
        public IList<Constructor260> constructors { get; set; }
        public IList<Method451> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter402
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method452
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter402> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class NoSuchElementException
    {
        public IList<object> constructors { get; set; }
        public IList<Method452> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor261
    {
        public object name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter403
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method453
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter403> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class NullPointerException
    {
        public IList<Constructor261> constructors { get; set; }
        public IList<Method453> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter404
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor262
    {
        public object name { get; set; }
        public IList<Parameter404> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter405
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method454
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter405> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class PageReference
    {
        public IList<Constructor262> constructors { get; set; }
        public IList<Method454> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter406
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method455
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter406> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Pattern
    {
        public IList<object> constructors { get; set; }
        public IList<Method455> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter407
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method456
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter407> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ProcedureException
    {
        public IList<object> constructors { get; set; }
        public IList<Method456> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor263
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter408
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method457
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter408> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ProductSecurity
    {
        public IList<Constructor263> constructors { get; set; }
        public IList<Method457> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter409
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method458
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter409> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class QueryException
    {
        public IList<object> constructors { get; set; }
        public IList<Method458> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter410
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method459
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter410> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Queueable
    {
        public IList<object> constructors { get; set; }
        public IList<Method459> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method460
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class QueueableContext
    {
        public IList<object> constructors { get; set; }
        public IList<Method460> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method461
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class QueueableContextImpl
    {
        public IList<object> constructors { get; set; }
        public IList<Method461> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor264
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter411
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method462
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter411> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class RemoteObjectController
    {
        public IList<Constructor264> constructors { get; set; }
        public IList<Method462> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter412
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method463
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter412> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class RequiredFeatureMissingException
    {
        public IList<object> constructors { get; set; }
        public IList<Method463> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method464
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ResetPasswordResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method464> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Property265
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class RestContext
    {
        public IList<object> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property265> properties { get; set; }
    }

    public class Constructor265
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter413
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method465
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter413> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property266
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class RestRequest
    {
        public IList<Constructor265> constructors { get; set; }
        public IList<Method465> methods { get; set; }
        public IList<Property266> properties { get; set; }
    }

    public class Constructor266
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter414
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method466
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter414> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property267
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class RestResponse
    {
        public IList<Constructor266> constructors { get; set; }
        public IList<Method466> methods { get; set; }
        public IList<Property267> properties { get; set; }
    }

    public class Parameter415
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method467
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter415> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SObject
    {
        public IList<object> constructors { get; set; }
        public IList<Method467> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter416
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method468
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter416> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SObjectException
    {
        public IList<object> constructors { get; set; }
        public IList<Method468> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter417
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method469
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter417> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Schedulable
    {
        public IList<object> constructors { get; set; }
        public IList<Method469> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method470
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SchedulableContext
    {
        public IList<object> constructors { get; set; }
        public IList<Method470> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter418
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method471
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter418> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Schema2
    {
        public IList<object> constructors { get; set; }
        public IList<Method471> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter419
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method472
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter419> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SearchException
    {
        public IList<object> constructors { get; set; }
        public IList<Method472> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter420
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method473
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter420> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SecurityException
    {
        public IList<object> constructors { get; set; }
        public IList<Method473> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter421
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor267
    {
        public object name { get; set; }
        public IList<Parameter421> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter422
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method474
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter422> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SelectOption
    {
        public IList<Constructor267> constructors { get; set; }
        public IList<Method474> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter423
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method475
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter423> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SerializationException
    {
        public IList<object> constructors { get; set; }
        public IList<Method475> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter424
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method476
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter424> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Set
    {
        public IList<object> constructors { get; set; }
        public IList<Method476> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter425
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method477
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter425> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property268
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class SetupScope
    {
        public IList<object> constructors { get; set; }
        public IList<Method477> methods { get; set; }
        public IList<Property268> properties { get; set; }
    }

    public class Constructor268
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter426
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method478
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter426> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Site2
    {
        public IList<Constructor268> constructors { get; set; }
        public IList<Method478> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor269
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter427
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method479
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter427> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class StaticResourceCalloutMock
    {
        public IList<Constructor269> constructors { get; set; }
        public IList<Method479> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter428
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method480
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter428> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property269
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class StatusCode
    {
        public IList<object> constructors { get; set; }
        public IList<Method480> methods { get; set; }
        public IList<Property269> properties { get; set; }
    }

    public class Parameter429
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method481
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter429> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class String
    {
        public IList<object> constructors { get; set; }
        public IList<Method481> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter430
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method482
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter430> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class StringException
    {
        public IList<object> constructors { get; set; }
        public IList<Method482> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter431
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method483
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter431> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class System2
    {
        public IList<object> constructors { get; set; }
        public IList<Method483> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor270
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter432
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method484
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter432> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Test2
    {
        public IList<Constructor270> constructors { get; set; }
        public IList<Method484> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter433
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method485
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter433> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Time
    {
        public IList<object> constructors { get; set; }
        public IList<Method485> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter434
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method486
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter434> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class TimeZone2
    {
        public IList<object> constructors { get; set; }
        public IList<Method486> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter435
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor271
    {
        public object name { get; set; }
        public IList<Parameter435> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter436
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method487
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter436> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class TouchHandledException
    {
        public IList<Constructor271> constructors { get; set; }
        public IList<Method487> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter437
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method488
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter437> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Type
    {
        public IList<object> constructors { get; set; }
        public IList<Method488> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter438
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method489
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter438> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class TypeException
    {
        public IList<object> constructors { get; set; }
        public IList<Method489> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter439
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method490
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter439> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class UnexpectedException
    {
        public IList<object> constructors { get; set; }
        public IList<Method490> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter440
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor272
    {
        public string name { get; set; }
        public IList<Parameter440> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method491
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class UnsupportedOperationException
    {
        public IList<Constructor272> constructors { get; set; }
        public IList<Method491> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter441
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor273
    {
        public string name { get; set; }
        public IList<Parameter441> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter442
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method492
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter442> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Url
    {
        public IList<Constructor273> constructors { get; set; }
        public IList<Method492> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor274
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter443
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method493
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter443> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class UserInfo
    {
        public IList<Constructor274> constructors { get; set; }
        public IList<Method493> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter444
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor275
    {
        public object name { get; set; }
        public IList<Parameter444> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter445
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method494
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter445> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Version
    {
        public IList<Constructor275> constructors { get; set; }
        public IList<Method494> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter446
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method495
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter446> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class VisualforceException
    {
        public IList<object> constructors { get; set; }
        public IList<Method495> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor276
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class WebServiceCalloutFuture
    {
        public IList<Constructor276> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter447
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method496
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter447> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class WebServiceMock
    {
        public IList<object> constructors { get; set; }
        public IList<Method496> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter448
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method497
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter448> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class XmlException
    {
        public IList<object> constructors { get; set; }
        public IList<Method497> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter449
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor277
    {
        public object name { get; set; }
        public IList<Parameter449> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter450
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method498
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter450> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class XmlStreamReader
    {
        public IList<Constructor277> constructors { get; set; }
        public IList<Method498> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor278
    {
        public object name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter451
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method499
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter451> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class XmlStreamWriter
    {
        public IList<Constructor278> constructors { get; set; }
        public IList<Method499> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter452
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method500
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter452> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property270
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class XmlTag
    {
        public IList<object> constructors { get; set; }
        public IList<Method500> methods { get; set; }
        public IList<Property270> properties { get; set; }
    }

    public class System
    {
        public Answers Answers { get; set; }
        public ApexPages2 ApexPages { get; set; }
        public AppExchange AppExchange { get; set; }
        public ApplicationReadWriteMode ApplicationReadWriteMode { get; set; }
        public AssertException AssertException { get; set; }
        public AsyncException AsyncException { get; set; }
        public Blob Blob { get; set; }
        public Boolean Boolean { get; set; }
        public BusinessHours BusinessHours { get; set; }
        public CURRENCY CURRENCY { get; set; }
        public CalloutException CalloutException { get; set; }
        public CanvasException CanvasException { get; set; }
        public Cases Cases { get; set; }
        public CollectSimilarCasesData CollectSimilarCasesData { get; set; }
        public Communities2 Communities { get; set; }
        public Comparable Comparable { get; set; }
        public Continuation Continuation { get; set; }
        public Cookie Cookie { get; set; }
        public Crypto Crypto { get; set; }
        public Database2 Database { get; set; }
        public Date Date { get; set; }
        public Datetime Datetime { get; set; }
        public Decimal Decimal { get; set; }
        public DmlException DmlException { get; set; }
        public Double Double { get; set; }
        public EmailException EmailException { get; set; }
        public EncodingUtil EncodingUtil { get; set; }
        public Exception Exception { get; set; }
        public FfxPortalData FfxPortalData { get; set; }
        public FinalException FinalException { get; set; }
        public FlowException FlowException { get; set; }
        public HandledException HandledException { get; set; }
        public Http Http { get; set; }
        public HttpCalloutMock HttpCalloutMock { get; set; }
        public HttpRequest HttpRequest { get; set; }
        public HttpResponse HttpResponse { get; set; }
        public Id Id { get; set; }
        public Ideas Ideas { get; set; }
        public Integer Integer { get; set; }
        public InvalidHeaderException InvalidHeaderException { get; set; }
        public InvalidParameterValueException InvalidParameterValueException { get; set; }
        public InvalidReadOnlyUserDmlException InvalidReadOnlyUserDmlException { get; set; }
        public Iterable Iterable { get; set; }
        public Iterator Iterator { get; set; }
        public JSON JSON { get; set; }
        public JSONException JSONException { get; set; }
        public JSONGenerator JSONGenerator { get; set; }
        public JSONParser JSONParser { get; set; }
        public JSONToken JSONToken { get; set; }
        public LIST LIST { get; set; }
        public LicenseException LicenseException { get; set; }
        public LimitException LimitException { get; set; }
        public ListException ListException { get; set; }
        public LoggingLevel LoggingLevel { get; set; }
        public Long Long { get; set; }
        public Map Map { get; set; }
        public Matcher Matcher { get; set; }
        public Math Math { get; set; }
        public MathException MathException { get; set; }
        public Messaging2 Messaging { get; set; }
        public MultiStaticResourceCalloutMock MultiStaticResourceCalloutMock { get; set; }
        public Network Network { get; set; }
        public NoAccessException NoAccessException { get; set; }
        public NoDataFoundException NoDataFoundException { get; set; }
        public NoSuchElementException NoSuchElementException { get; set; }
        public NullPointerException NullPointerException { get; set; }
        public PageReference PageReference { get; set; }
        public Pattern Pattern { get; set; }
        public ProcedureException ProcedureException { get; set; }
        public ProductSecurity ProductSecurity { get; set; }
        public QueryException QueryException { get; set; }
        public Queueable Queueable { get; set; }
        public QueueableContext QueueableContext { get; set; }
        public QueueableContextImpl QueueableContextImpl { get; set; }
        public RemoteObjectController RemoteObjectController { get; set; }
        public RequiredFeatureMissingException RequiredFeatureMissingException { get; set; }
        public ResetPasswordResult ResetPasswordResult { get; set; }
        public RestContext RestContext { get; set; }
        public RestRequest RestRequest { get; set; }
        public RestResponse RestResponse { get; set; }
        public SObject SObject { get; set; }
        public SObjectException SObjectException { get; set; }
        public Schedulable Schedulable { get; set; }
        public SchedulableContext SchedulableContext { get; set; }
        public Schema2 Schema { get; set; }
        public SearchException SearchException { get; set; }
        public SecurityException SecurityException { get; set; }
        public SelectOption SelectOption { get; set; }
        public SerializationException SerializationException { get; set; }
        public Set Set { get; set; }
        public SetupScope SetupScope { get; set; }
        public Site2 Site { get; set; }
        public StaticResourceCalloutMock StaticResourceCalloutMock { get; set; }
        public StatusCode StatusCode { get; set; }
        public String String { get; set; }
        public StringException StringException { get; set; }
        public System2 System2 { get; set; }
        public Test2 Test { get; set; }
        public Time Time { get; set; }
        public TimeZone2 TimeZone { get; set; }
        public TouchHandledException TouchHandledException { get; set; }
        public Type Type { get; set; }
        public TypeException TypeException { get; set; }
        public UnexpectedException UnexpectedException { get; set; }
        public UnsupportedOperationException UnsupportedOperationException { get; set; }
        public Url Url { get; set; }
        public UserInfo UserInfo { get; set; }
        public Version Version { get; set; }
        public VisualforceException VisualforceException { get; set; }
        public WebServiceCalloutFuture WebServiceCalloutFuture { get; set; }
        public WebServiceMock WebServiceMock { get; set; }
        public XmlException XmlException { get; set; }
        public XmlStreamReader XmlStreamReader { get; set; }
        public XmlStreamWriter XmlStreamWriter { get; set; }
        public XmlTag XmlTag { get; set; }
    }

    public class Parameter453
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor279
    {
        public string name { get; set; }
        public IList<Parameter453> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Property271
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Event
    {
        public IList<Constructor279> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property271> properties { get; set; }
    }

    public class Parameter454
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method501
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter454> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class PolicyCondition
    {
        public IList<object> constructors { get; set; }
        public IList<Method501> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class TxnSecurity
    {
        public Event Event { get; set; }
        public PolicyCondition PolicyCondition { get; set; }
    }

    public class Constructor280
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class DocsController
    {
        public IList<Constructor280> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class UIGuide
    {
        public DocsController DocsController { get; set; }
    }

    public class Constructor281
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method502
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class AppLauncherApexController
    {
        public IList<Constructor281> constructors { get; set; }
        public IList<Method502> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Applauncher
    {
        public AppLauncherApexController AppLauncherApexController { get; set; }
    }

    public class Constructor282
    {
        public object name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter455
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method503
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter455> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Document
    {
        public IList<Constructor282> constructors { get; set; }
        public IList<Method503> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter456
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method504
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter456> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class XmlNode
    {
        public IList<object> constructors { get; set; }
        public IList<Method504> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter457
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method505
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter457> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property272
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class XmlNodeType
    {
        public IList<object> constructors { get; set; }
        public IList<Method505> methods { get; set; }
        public IList<Property272> properties { get; set; }
    }

    public class Dom
    {
        public Document Document { get; set; }
        public XmlNode XmlNode { get; set; }
        public XmlNodeType XmlNodeType { get; set; }
    }

    public class Parameter458
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor283
    {
        public string name { get; set; }
        public IList<Parameter458> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method506
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class AnalysisException
    {
        public IList<Constructor283> constructors { get; set; }
        public IList<Method506> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method507
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class BasePredictedFieldImpl
    {
        public IList<object> constructors { get; set; }
        public IList<Method507> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method508
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class BooleanPredictedField
    {
        public IList<object> constructors { get; set; }
        public IList<Method508> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor284
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method509
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class CategoricalFieldTreatment
    {
        public IList<Constructor284> constructors { get; set; }
        public IList<Method509> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method510
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DatePredictedField
    {
        public IList<object> constructors { get; set; }
        public IList<Method510> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method511
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DoublePredictedField
    {
        public IList<object> constructors { get; set; }
        public IList<Method511> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method512
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class FieldTreatment
    {
        public IList<object> constructors { get; set; }
        public IList<Method512> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter459
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method513
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter459> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property273
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class FieldTreatmentType
    {
        public IList<object> constructors { get; set; }
        public IList<Method513> methods { get; set; }
        public IList<Property273> properties { get; set; }
    }

    public class Method514
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ItemPresenceReason
    {
        public IList<object> constructors { get; set; }
        public IList<Method514> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor285
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method515
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class NumberFieldTreatment
    {
        public IList<Constructor285> constructors { get; set; }
        public IList<Method515> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter460
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method516
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter460> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ObjectAnalysis
    {
        public IList<object> constructors { get; set; }
        public IList<Method516> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor286
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter461
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method517
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter461> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ObjectAnalysisService
    {
        public IList<Constructor286> constructors { get; set; }
        public IList<Method517> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter462
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method518
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter462> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property274
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ObjectRefreshState
    {
        public IList<object> constructors { get; set; }
        public IList<Method518> methods { get; set; }
        public IList<Property274> properties { get; set; }
    }

    public class Method519
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ObjectRefreshStatus
    {
        public IList<object> constructors { get; set; }
        public IList<Method519> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter463
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor287
    {
        public string name { get; set; }
        public IList<Parameter463> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter464
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method520
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter464> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ObjectTreatment
    {
        public IList<Constructor287> constructors { get; set; }
        public IList<Method520> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor288
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method521
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class OmittedFieldTreatment
    {
        public IList<Constructor288> constructors { get; set; }
        public IList<Method521> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method522
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class PredictedField
    {
        public IList<object> constructors { get; set; }
        public IList<Method522> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter465
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method523
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter465> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property275
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class PredictedFieldType
    {
        public IList<object> constructors { get; set; }
        public IList<Method523> methods { get; set; }
        public IList<Property275> properties { get; set; }
    }

    public class Method524
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class PredictedResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method524> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter466
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor289
    {
        public string name { get; set; }
        public IList<Parameter466> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method525
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class PredictiveException
    {
        public IList<Constructor289> constructors { get; set; }
        public IList<Method525> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor290
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method526
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class PresenceFlagFieldTreatment
    {
        public IList<Constructor290> constructors { get; set; }
        public IList<Method526> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method527
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class PresenceReason
    {
        public IList<object> constructors { get; set; }
        public IList<Method527> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter467
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor291
    {
        public string name { get; set; }
        public IList<Parameter467> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method528
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class QueryException2
    {
        public IList<Constructor291> constructors { get; set; }
        public IList<Method528> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method529
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Reason
    {
        public IList<object> constructors { get; set; }
        public IList<Method529> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter468
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method530
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter468> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property276
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ReasonType
    {
        public IList<object> constructors { get; set; }
        public IList<Method530> methods { get; set; }
        public IList<Property276> properties { get; set; }
    }

    public class Parameter469
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor292
    {
        public string name { get; set; }
        public IList<Parameter469> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter470
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method531
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter470> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class RelatedField
    {
        public IList<Constructor292> constructors { get; set; }
        public IList<Method531> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter471
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor293
    {
        public string name { get; set; }
        public IList<Parameter471> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter472
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method532
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter472> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class RelatedResult
    {
        public IList<Constructor293> constructors { get; set; }
        public IList<Method532> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor294
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter473
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method533
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter473> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Row
    {
        public IList<Constructor294> constructors { get; set; }
        public IList<Method533> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter474
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor295
    {
        public string name { get; set; }
        public IList<Parameter474> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter475
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method534
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter475> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SetFieldTreatment
    {
        public IList<Constructor295> constructors { get; set; }
        public IList<Method534> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method535
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SimilarRecord
    {
        public IList<object> constructors { get; set; }
        public IList<Method535> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method536
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SimilarResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method536> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method537
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class StringPredictedField
    {
        public IList<object> constructors { get; set; }
        public IList<Method537> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter476
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor296
    {
        public string name { get; set; }
        public IList<Parameter476> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter477
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method538
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter477> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class TextFieldTreatment
    {
        public IList<Constructor296> constructors { get; set; }
        public IList<Method538> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter478
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor297
    {
        public string name { get; set; }
        public IList<Parameter478> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter479
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method539
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter479> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class TimeDeltaFieldTreatment
    {
        public IList<Constructor297> constructors { get; set; }
        public IList<Method539> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method540
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ValueReason
    {
        public IList<object> constructors { get; set; }
        public IList<Method540> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method541
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class WordPresenceReason
    {
        public IList<object> constructors { get; set; }
        public IList<Method541> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Predictive
    {
        public AnalysisException AnalysisException { get; set; }
        public BasePredictedFieldImpl BasePredictedFieldImpl { get; set; }
        public BooleanPredictedField BooleanPredictedField { get; set; }
        public CategoricalFieldTreatment CategoricalFieldTreatment { get; set; }
        public DatePredictedField DatePredictedField { get; set; }
        public DoublePredictedField DoublePredictedField { get; set; }
        public FieldTreatment FieldTreatment { get; set; }
        public FieldTreatmentType FieldTreatmentType { get; set; }
        public ItemPresenceReason ItemPresenceReason { get; set; }
        public NumberFieldTreatment NumberFieldTreatment { get; set; }
        public ObjectAnalysis ObjectAnalysis { get; set; }
        public ObjectAnalysisService ObjectAnalysisService { get; set; }
        public ObjectRefreshState ObjectRefreshState { get; set; }
        public ObjectRefreshStatus ObjectRefreshStatus { get; set; }
        public ObjectTreatment ObjectTreatment { get; set; }
        public OmittedFieldTreatment OmittedFieldTreatment { get; set; }
        public PredictedField PredictedField { get; set; }
        public PredictedFieldType PredictedFieldType { get; set; }
        public PredictedResult PredictedResult { get; set; }
        public PredictiveException PredictiveException { get; set; }
        public PresenceFlagFieldTreatment PresenceFlagFieldTreatment { get; set; }
        public PresenceReason PresenceReason { get; set; }
        public QueryException2 QueryException { get; set; }
        public Reason Reason { get; set; }
        public ReasonType ReasonType { get; set; }
        public RelatedField RelatedField { get; set; }
        public RelatedResult RelatedResult { get; set; }
        public Row Row { get; set; }
        public SetFieldTreatment SetFieldTreatment { get; set; }
        public SimilarRecord SimilarRecord { get; set; }
        public SimilarResult SimilarResult { get; set; }
        public StringPredictedField StringPredictedField { get; set; }
        public TextFieldTreatment TextFieldTreatment { get; set; }
        public TimeDeltaFieldTreatment TimeDeltaFieldTreatment { get; set; }
        public ValueReason ValueReason { get; set; }
        public WordPresenceReason WordPresenceReason { get; set; }
    }

    public class Method542
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class AggregateColumn
    {
        public IList<object> constructors { get; set; }
        public IList<Method542> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter480
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method543
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter480> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property277
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ColumnDataType
    {
        public IList<object> constructors { get; set; }
        public IList<Method543> methods { get; set; }
        public IList<Property277> properties { get; set; }
    }

    public class Parameter481
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method544
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter481> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property278
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ColumnSortOrder
    {
        public IList<object> constructors { get; set; }
        public IList<Method544> methods { get; set; }
        public IList<Property278> properties { get; set; }
    }

    public class Parameter482
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method545
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter482> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property279
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class DateGranularity
    {
        public IList<object> constructors { get; set; }
        public IList<Method545> methods { get; set; }
        public IList<Property279> properties { get; set; }
    }

    public class Method546
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class DetailColumn
    {
        public IList<object> constructors { get; set; }
        public IList<Method546> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method547
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Dimension
    {
        public IList<object> constructors { get; set; }
        public IList<Method547> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter483
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor298
    {
        public string name { get; set; }
        public IList<Parameter483> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method548
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class EvaluatedCondition
    {
        public IList<Constructor298> constructors { get; set; }
        public IList<Method548> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter484
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method549
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter484> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property280
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class EvaluatedConditionOperator
    {
        public IList<object> constructors { get; set; }
        public IList<Method549> methods { get; set; }
        public IList<Property280> properties { get; set; }
    }

    public class Parameter485
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor299
    {
        public string name { get; set; }
        public IList<Parameter485> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method550
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class FeatureNotSupportedException
    {
        public IList<Constructor299> constructors { get; set; }
        public IList<Method550> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method551
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class FilterOperator
    {
        public IList<object> constructors { get; set; }
        public IList<Method551> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method552
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class FilterValue
    {
        public IList<object> constructors { get; set; }
        public IList<Method552> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method553
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class GroupingColumn
    {
        public IList<object> constructors { get; set; }
        public IList<Method553> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter486
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor300
    {
        public string name { get; set; }
        public IList<Parameter486> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter487
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method554
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter487> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class GroupingInfo
    {
        public IList<Constructor300> constructors { get; set; }
        public IList<Method554> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method555
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class GroupingValue
    {
        public IList<object> constructors { get; set; }
        public IList<Method555> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter488
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor301
    {
        public string name { get; set; }
        public IList<Parameter488> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method556
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class InstanceAccessException
    {
        public IList<Constructor301> constructors { get; set; }
        public IList<Method556> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter489
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor302
    {
        public string name { get; set; }
        public IList<Parameter489> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method557
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class InvalidFilterException
    {
        public IList<Constructor302> constructors { get; set; }
        public IList<Method557> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter490
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor303
    {
        public string name { get; set; }
        public IList<Parameter490> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method558
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class InvalidReportMetadataException
    {
        public IList<Constructor303> constructors { get; set; }
        public IList<Method558> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter491
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor304
    {
        public string name { get; set; }
        public IList<Parameter491> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method559
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class InvalidSnapshotDateException
    {
        public IList<Constructor304> constructors { get; set; }
        public IList<Method559> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter492
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor305
    {
        public string name { get; set; }
        public IList<Parameter492> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method560
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class MetadataException
    {
        public IList<Constructor305> constructors { get; set; }
        public IList<Method560> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter493
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method561
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter493> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class NotificationAction
    {
        public IList<object> constructors { get; set; }
        public IList<Method561> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter494
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor306
    {
        public string name { get; set; }
        public IList<Parameter494> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method562
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class NotificationActionContext
    {
        public IList<Constructor306> constructors { get; set; }
        public IList<Method562> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method563
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportCurrency
    {
        public IList<object> constructors { get; set; }
        public IList<Method563> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method564
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportDataCell
    {
        public IList<object> constructors { get; set; }
        public IList<Method564> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method565
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportDescribeResult
    {
        public IList<object> constructors { get; set; }
        public IList<Method565> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method566
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportDetailRow
    {
        public IList<object> constructors { get; set; }
        public IList<Method566> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method567
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportExtendedMetadata
    {
        public IList<object> constructors { get; set; }
        public IList<Method567> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method568
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportFact
    {
        public IList<object> constructors { get; set; }
        public IList<Method568> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method569
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportFactWithDetails
    {
        public IList<object> constructors { get; set; }
        public IList<Method569> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method570
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportFactWithSummaries
    {
        public IList<object> constructors { get; set; }
        public IList<Method570> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter495
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor307
    {
        public string name { get; set; }
        public IList<Parameter495> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter496
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method571
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter496> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportFilter
    {
        public IList<Constructor307> constructors { get; set; }
        public IList<Method571> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter497
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method572
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter497> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Property281
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class ReportFormat
    {
        public IList<object> constructors { get; set; }
        public IList<Method572> methods { get; set; }
        public IList<Property281> properties { get; set; }
    }

    public class Method573
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportInstance
    {
        public IList<object> constructors { get; set; }
        public IList<Method573> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method574
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportInstanceAttributes
    {
        public IList<object> constructors { get; set; }
        public IList<Method574> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Constructor308
    {
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter498
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method575
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter498> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportManager
    {
        public IList<Constructor308> constructors { get; set; }
        public IList<Method575> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter499
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor309
    {
        public string name { get; set; }
        public IList<Parameter499> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter500
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method576
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter500> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportMetadata
    {
        public IList<Constructor309> constructors { get; set; }
        public IList<Method576> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method577
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportResults
    {
        public IList<object> constructors { get; set; }
        public IList<Method577> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter501
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor310
    {
        public string name { get; set; }
        public IList<Parameter501> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method578
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportRunException
    {
        public IList<Constructor310> constructors { get; set; }
        public IList<Method578> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter502
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor311
    {
        public string name { get; set; }
        public IList<Parameter502> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Parameter503
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method579
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter503> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportType
    {
        public IList<Constructor311> constructors { get; set; }
        public IList<Method579> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method580
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportTypeColumn
    {
        public IList<object> constructors { get; set; }
        public IList<Method580> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method581
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportTypeColumnCategory
    {
        public IList<object> constructors { get; set; }
        public IList<Method581> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method582
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ReportTypeMetadata
    {
        public IList<object> constructors { get; set; }
        public IList<Method582> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method583
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class SummaryValue
    {
        public IList<object> constructors { get; set; }
        public IList<Method583> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter504
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor312
    {
        public string name { get; set; }
        public IList<Parameter504> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method584
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ThresholdInformation
    {
        public IList<Constructor312> constructors { get; set; }
        public IList<Method584> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Parameter505
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Constructor313
    {
        public string name { get; set; }
        public IList<Parameter505> parameters { get; set; }
        public IList<object> references { get; set; }
    }

    public class Method585
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class UnsupportedOperationException2
    {
        public IList<Constructor313> constructors { get; set; }
        public IList<Method585> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Reports
    {
        public AggregateColumn AggregateColumn { get; set; }
        public ColumnDataType ColumnDataType { get; set; }
        public ColumnSortOrder ColumnSortOrder { get; set; }
        public DateGranularity DateGranularity { get; set; }
        public DetailColumn DetailColumn { get; set; }
        public Dimension Dimension { get; set; }
        public EvaluatedCondition EvaluatedCondition { get; set; }
        public EvaluatedConditionOperator EvaluatedConditionOperator { get; set; }
        public FeatureNotSupportedException FeatureNotSupportedException { get; set; }
        public FilterOperator FilterOperator { get; set; }
        public FilterValue FilterValue { get; set; }
        public GroupingColumn GroupingColumn { get; set; }
        public GroupingInfo GroupingInfo { get; set; }
        public GroupingValue GroupingValue { get; set; }
        public InstanceAccessException InstanceAccessException { get; set; }
        public InvalidFilterException InvalidFilterException { get; set; }
        public InvalidReportMetadataException InvalidReportMetadataException { get; set; }
        public InvalidSnapshotDateException InvalidSnapshotDateException { get; set; }
        public MetadataException MetadataException { get; set; }
        public NotificationAction NotificationAction { get; set; }
        public NotificationActionContext NotificationActionContext { get; set; }
        public ReportCurrency ReportCurrency { get; set; }
        public ReportDataCell ReportDataCell { get; set; }
        public ReportDescribeResult ReportDescribeResult { get; set; }
        public ReportDetailRow ReportDetailRow { get; set; }
        public ReportExtendedMetadata ReportExtendedMetadata { get; set; }
        public ReportFact ReportFact { get; set; }
        public ReportFactWithDetails ReportFactWithDetails { get; set; }
        public ReportFactWithSummaries ReportFactWithSummaries { get; set; }
        public ReportFilter ReportFilter { get; set; }
        public ReportFormat ReportFormat { get; set; }
        public ReportInstance ReportInstance { get; set; }
        public ReportInstanceAttributes ReportInstanceAttributes { get; set; }
        public ReportManager ReportManager { get; set; }
        public ReportMetadata ReportMetadata { get; set; }
        public ReportResults ReportResults { get; set; }
        public ReportRunException ReportRunException { get; set; }
        public ReportType ReportType { get; set; }
        public ReportTypeColumn ReportTypeColumn { get; set; }
        public ReportTypeColumnCategory ReportTypeColumnCategory { get; set; }
        public ReportTypeMetadata ReportTypeMetadata { get; set; }
        public SummaryValue SummaryValue { get; set; }
        public ThresholdInformation ThresholdInformation { get; set; }
        public UnsupportedOperationException2 UnsupportedOperationException { get; set; }
    }

    public class Parameter506
    {
        public string name { get; set; }
        public string type { get; set; }
    }

    public class Method586
    {
        public IList<string> argTypes { get; set; }
        public string name { get; set; }
        public IList<Parameter506> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class Action2
    {
        public IList<object> constructors { get; set; }
        public IList<Method586> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Method587
    {
        public IList<object> argTypes { get; set; }
        public string name { get; set; }
        public IList<object> parameters { get; set; }
        public IList<object> references { get; set; }
        public string returnType { get; set; }
    }

    public class ActionDml
    {
        public IList<object> constructors { get; set; }
        public IList<Method587> methods { get; set; }
        public IList<object> properties { get; set; }
    }

    public class Property282
    {
        public string name { get; set; }
        public IList<object> references { get; set; }
    }

    public class Context
    {
        public IList<object> constructors { get; set; }
        public IList<object> methods { get; set; }
        public IList<Property282> properties { get; set; }
    }

    public class Workflow
    {
        public Action2 Action { get; set; }
        public ActionDml ActionDml { get; set; }
        public Context Context { get; set; }
    }
}

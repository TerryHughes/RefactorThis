Hi and welcome to team Amazing Electronic Code Cluster (Blue-Cyan). As you know, we are a large provide of things that exist solely in a nebulus mass of stuff (like tubes, interconnected tubes, a whole series of them). Anyway, you're not the astronaut in charge of designing it, we hired you to do useful work. Here's a run down of the existing functionality.

* A region can contain zero to many availability zones
* An availability zone can contain zero to many instances
* Instances need to have valid account numbers when supplied
* Instances with an availability zone must be uniquely named
* Instances can only be inactivated in certain situations (the actual situations are not important, but inactivation needs to be prevented when they occur)

We recently experienced ... well let's say something that is statistically distinguishable from perfect. An availability zone was not available yet we continued to try and add instances to it and update existing instance. It wasn't a good situation. This caused us to think that we should handle that a little better. You're first task is to implement the following functionality.

* Don't save the instance when its availability zone is not available

We've decided to allow for three levels of changes (so please specify which level you are solving for). Remember that whichever path you choose the existing functionality must be maintained and the new functionality must work correctly.

* Free rein, you are allowed to change everything within the current system
* Restricted, you are only allowed to change the Save method in InstanceController (this includes changing the content and the signature). You can add new classes and extension methods but you cannot change any other existing class (with the exception of the Program class of course)
* Compatability, you are only allowed to change the contents of the Save method in InstanceController. Again, you can add new classes and extension methods but you cannot change any other existing class (with the exception of the Program class of course)

FAQ
Yes, this was adapted from real production code.
No, it has nothing to do with cloud technology.
Yes, I am familiar with the offending code.
No, I didn't originally write it.
Yes, I have added to it's nastiness.
No, I don't feel good about it.
Yes, you are awesome and want to impress me.
No, you are not solving a problem for me (it's just a piece of crazy code I was looking at recently and thought it'd make for a good refactoring exercise).

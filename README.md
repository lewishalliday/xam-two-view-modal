# Xamarin Forms Two View Modal

A quick sample app to demo how two views can be presented in a "page-like" fashion within a modal

## Problem

- Using PushModalAsync for the 2nd page makes the page appear from the bottom
- Embedding the Modal content in a second NavigationPage cause the modal to show full screen and loses the Modal Style

## Solution

- Use a single page for the modal, and use views to manage the "faux-pages" and manage animations to transition between.

The majority of the heavy lifting is done from the code-behind of the [ModalPage](https://github.com/adenearnshaw/xam-two-view-modal/blob/master/src/XF.ModalNavigation/Views/ModalPageOne.xaml.cs). This is where all the animations which control which ModalView is shown is managed

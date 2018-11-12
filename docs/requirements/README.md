# Application Requirements

#**News Feed Application Requirements**
#
##**Searches**

###**Viewing Searches**
- VS01 - Upon a "Tag" being clicked on and while the user is not in editing mode(ref. ET01), the system shall display the most up to date news and articles related to the "Tags" specific search.
- VS02 - Upon (ref. VS01) and while the user no longer wishes to see a specifics websites information, the system will allow the user to block all content from that specific website.
### **Suggested Searches** ###
- US01 - Upon receiving text based input in the search bar on the home screen and while the text is being entered, the System shall display searches that have similar keywords, before the next word is typed by the user.
- US02 - Upon receiving a request for a search, either from a users description or a suggested search (ref. US01) the system shall ask the user to either add the search to their list of searches(ref. AS01) or view the contents of the search(//TODO).

### **Adding Searches(Tags)** ###
- AS01 - Upon the referenced condition (ref. US02), when the user selects to add the search to their list of searches, the system shall add the search text as a "Tag", before the system displays a list of all "Tags".
- AS02 - Upon (ref. AS01), when the "Tag" is added the System shall place the newly added tag at the top of the "Tags" page.
- AS03 - Upon (ref. AS01), The System will provide an option that allows the user to add the "Tag" to the Home page of the application. 



### **Editing Searches(Tags)**
- ET01 - Upon the user viewing the "Tags" page, the System will have an option to place the page in editing mode while the switch for this mode is placed in the "ON" position.
- ET02 - Upon the referenced condition (ref. ET01) the user can rename any of the tags on the page by deleting the previous text, adding the new text, and then following (ref. ET05).
- ET03 - Upon the referenced condition (ref. ET01) the user can change the picture of any of the tags when the previous picture is placed in the garbage can (ref. ET06) and the new picture is uploaded to the Tag(ref. ET07).
- ET04 - Upon the referenced condition (ref. ET01) the user can change the ordering of any of the tags by clicking and holding a specific "Tag" and dragging that tag to it's new position where it will snap into place.
- ET05 - Upon the referenced condition (ref. ET01) the system will display a button labeled "Save Changes", that when pressed will save all changes made.
- ET06 - Upon the referenced condition (ref. ET01) the system will display a garbage can icon, that allows the user to delete "Tag" pictures or the entire "Tag".
- ET07 - Upon the referenced condition (ref. ET01) the system will display a button labeled "Upload Images", that when pressed will allow the user to click on any "Tags" currently without Images and upload an image that is 300 x 250 pixels to the users selected "Tag".

##**Articles**

###**Save Articles**
- SA01 - Upon the referenced condition (ref. VS01), and while the user is viewing an article and wants to reference the article at a time in the future, the system will allow the user to save the article to a page labeled "Articles".
- SA02 - Upon the users decision to edit the article, the editing feature of the articles page will follow that of the "Tags" page (refs. ET01-07).


##**Login**


###**Signup**
- SU01 - Upon the system being in a non logged in state and while the user does not currently have an account with the application, the system shall prompt the user to create an account to use the application.
- SU02 - Upon the referenced condition (ref. SU01), the user will be able to create a user name while the name is not currently in use and contains at least 8 characters.
- SU03 - Upon the referenced condition (ref. SU01) the user will be able to create a password for the application, while the password is longer than 8 characters, contains a special character, and contains at least one number.
- SU04 - Upon the referenced condition (ref. SU01) the user will have to enter a valid email address that will need to be verified before the application can be used.

###**Verify Login**
- VL01 - Upon the system being in a non logged in state and while the user has an account with the application, the system will prompt the user to enter their user name and password to gain access to the application.
- VL02 - Upon the referenced condition (ref. VL01), and while the user's attempts to gain access to the account is less than 6, the user can keep trying, otherwise the system will prompt the user to change their password for the account and try again.
# Git Cheatsheet

A cheatsheet for common Git commands.

## Table of Contents
- [Setup and Configuration](#setup-and-configuration)
- [Basic Commands](#basic-commands)
- [Branching and Merging](#branching-and-merging)
- [Staging and Committing](#staging-and-committing)
- [Remote Repositories](#remote-repositories)
- [Viewing History and Diffs](#viewing-history-and-diffs)

## Setup and Configuration
- **Set your name**: `git config --global user.name "Your Name"`
- **Set your email**: `git config --global user.email "your.email@example.com"`
- **Check config**: `git config --list`
- **Set default editor (e.g., Vim)**: `git config --global core.editor "vim"`

## Basic Commands
- **Initialize a new repository**: `git init`
- **Clone a repository**: `git clone <url>`
- **Check status**: `git status`
- **View changes**: `git diff`

## Branching and Merging
- **List branches**: `git branch`
- **Create a new branch**: `git branch <branch-name>`
- **Switch to a branch**: `git checkout <branch-name>`
- **Create and switch to a new branch**: `git checkout -b <branch-name>`
- **Merge a branch**: `git merge <branch-name>`
- **Delete a branch**: `git branch -d <branch-name>`

## Staging and Committing
- **Stage files**: `git add <file>` or `git add .` (stages all changes)
- **Commit changes**: `git commit -m "Your commit message"`
- **View commit history**: `git log`

## Remote Repositories
- **Add a remote**: `git remote add origin <url>`
- **Push to remote**: `git push origin <branch-name>`
- **Pull from remote**: `git pull origin <branch-name>`
- **Fetch without merging**: `git fetch origin`

## Viewing History and Diffs
- **View changes in a file**: `git diff <file>`
- **View who changed what**: `git blame <file>`

---

# GNU Make project makefile autogenerated by Premake

ifndef config
  config=debug_any_cpu
endif

ifndef verbose
  SILENT = @
endif

.PHONY: clean prebuild prelink

ifeq ($(config),debug_any_cpu)
  CSC = mcs
  RESGEN = resgen
  TARGETDIR = ../bin
  TARGET = $(TARGETDIR)/slua-standalone-tests.dll
  OBJDIR = obj/Any\ CPU/Debug/slua-standalone-tests
  FLAGS = /unsafe /debug /noconfig /d:_DEBUG /d:DEBUG /d:TRACE
  DEPENDS = ../bin/slua-standalone.dll
  REFERENCES = /r:../bin/slua-standalone.dll
  define PREBUILDCMDS
  endef
  define PRELINKCMDS
  endef
  define POSTBUILDCMDS
  endef
endif

ifeq ($(config),release_any_cpu)
  CSC = mcs
  RESGEN = resgen
  TARGETDIR = ../bin
  TARGET = $(TARGETDIR)/slua-standalone-tests.dll
  OBJDIR = obj/Any\ CPU/Release/slua-standalone-tests
  FLAGS = /unsafe /optimize /noconfig
  DEPENDS = ../bin/slua-standalone.dll
  REFERENCES = /r:../bin/slua-standalone.dll
  define PREBUILDCMDS
  endef
  define PRELINKCMDS
  endef
  define POSTBUILDCMDS
  endef
endif

FLAGS += /t:library 
REFERENCES += /r:System /r:../packages/NUnit.2.6.4/lib/nunit.framework.dll

SOURCES += \
	../slua-standalone-tests/Demo.cs \
	../slua-standalone-tests/TestArray.cs \
	../slua-standalone-tests/TestClass.cs \
	../slua-standalone-tests/TestDLL.cs \
	../slua-standalone-tests/TestEnum.cs \
	../slua-standalone-tests/TestProperty.cs \
	../slua-standalone-tests/TestSLua.cs \
	../slua-standalone-tests/TestStruct.cs \

EMBEDFILES += \

RESPONSE += $(OBJDIR)/slua-standalone-tests.rsp
SHELLTYPE := msdos
ifeq (,$(ComSpec)$(COMSPEC))
  SHELLTYPE := posix
endif
ifeq (/bin,$(findstring /bin,$(SHELL)))
  SHELLTYPE := posix
endif

all: $(TARGETDIR) $(OBJDIR) prebuild $(EMBEDFILES) $(COPYFILES) prelink $(TARGET)

$(TARGET): $(SOURCES) $(EMBEDFILES) $(DEPENDS) $(RESPONSE)
	$(SILENT) $(CSC) /nologo /out:$@ $(FLAGS) $(REFERENCES) @$(RESPONSE) $(patsubst %,/resource:%,$(EMBEDFILES))
	$(POSTBUILDCMDS)

$(TARGETDIR):
	@echo Creating $(TARGETDIR)
ifeq (posix,$(SHELLTYPE))
	$(SILENT) mkdir -p $(TARGETDIR)
else
	$(SILENT) mkdir $(subst /,\\,$(TARGETDIR))
endif

$(RESPONSE): slua-standalone-tests.make
	@echo Generating response file
ifeq (posix,$(SHELLTYPE))
	$(SILENT) rm -f $(RESPONSE)
else
	$(SILENT) if exist $(RESPONSE) del $(OBJDIR)\slua-standalone-tests.rsp
endif
	@echo ../slua-standalone-tests/Demo.cs >> $(RESPONSE)
	@echo ../slua-standalone-tests/TestArray.cs >> $(RESPONSE)
	@echo ../slua-standalone-tests/TestClass.cs >> $(RESPONSE)
	@echo ../slua-standalone-tests/TestDLL.cs >> $(RESPONSE)
	@echo ../slua-standalone-tests/TestEnum.cs >> $(RESPONSE)
	@echo ../slua-standalone-tests/TestProperty.cs >> $(RESPONSE)
	@echo ../slua-standalone-tests/TestSLua.cs >> $(RESPONSE)
	@echo ../slua-standalone-tests/TestStruct.cs >> $(RESPONSE)

$(OBJDIR):
	@echo Creating $(OBJDIR)
ifeq (posix,$(SHELLTYPE))
	$(SILENT) mkdir -p $(OBJDIR)
else
	$(SILENT) mkdir $(subst /,\\,$(OBJDIR))
endif

prebuild:
	$(PREBUILDCMDS)

prelink:
	$(PRELINKCMDS)

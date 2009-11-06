

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0366 */
/* at Tue Sep 01 00:02:34 2009
 */
/* Compiler settings for .\OpcDaWrapper.idl:
    Oicf, W1, Zp8, env=Win32 (32b run)
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
//@@MIDL_FILE_HEADING(  )

#pragma warning( disable: 4049 )  /* more than 64k source lines */


/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 475
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#ifndef COM_NO_WINDOWS_H
#include "windows.h"
#include "ole2.h"
#endif /*COM_NO_WINDOWS_H*/

#ifndef __OpcDaWrapper_h__
#define __OpcDaWrapper_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

/* Forward Declarations */ 

#ifndef __IOPCWrappedServer_FWD_DEFINED__
#define __IOPCWrappedServer_FWD_DEFINED__
typedef interface IOPCWrappedServer IOPCWrappedServer;
#endif 	/* __IOPCWrappedServer_FWD_DEFINED__ */


#ifndef __OpcDaWrapper_FWD_DEFINED__
#define __OpcDaWrapper_FWD_DEFINED__

#ifdef __cplusplus
typedef class OpcDaWrapper OpcDaWrapper;
#else
typedef struct OpcDaWrapper OpcDaWrapper;
#endif /* __cplusplus */

#endif 	/* __OpcDaWrapper_FWD_DEFINED__ */


/* header files for imported files */
#include "opccomn.h"
#include "opcda.h"

#ifdef __cplusplus
extern "C"{
#endif 

void * __RPC_USER MIDL_user_allocate(size_t);
void __RPC_USER MIDL_user_free( void * ); 

#ifndef __IOPCWrappedServer_INTERFACE_DEFINED__
#define __IOPCWrappedServer_INTERFACE_DEFINED__

/* interface IOPCWrappedServer */
/* [unique][uuid][object] */ 


EXTERN_C const IID IID_IOPCWrappedServer;

#if defined(__cplusplus) && !defined(CINTERFACE)
    
    MIDL_INTERFACE("50E8496C-FA60-46a4-AF72-512494C664C6")
    IOPCWrappedServer : public IUnknown
    {
    public:
        virtual HRESULT STDMETHODCALLTYPE Load( 
            /* [in] */ REFCLSID tClsid) = 0;
        
        virtual HRESULT STDMETHODCALLTYPE Unload( void) = 0;
        
    };
    
#else 	/* C style interface */

    typedef struct IOPCWrappedServerVtbl
    {
        BEGIN_INTERFACE
        
        HRESULT ( STDMETHODCALLTYPE *QueryInterface )( 
            IOPCWrappedServer * This,
            /* [in] */ REFIID riid,
            /* [iid_is][out] */ void **ppvObject);
        
        ULONG ( STDMETHODCALLTYPE *AddRef )( 
            IOPCWrappedServer * This);
        
        ULONG ( STDMETHODCALLTYPE *Release )( 
            IOPCWrappedServer * This);
        
        HRESULT ( STDMETHODCALLTYPE *Load )( 
            IOPCWrappedServer * This,
            /* [in] */ REFCLSID tClsid);
        
        HRESULT ( STDMETHODCALLTYPE *Unload )( 
            IOPCWrappedServer * This);
        
        END_INTERFACE
    } IOPCWrappedServerVtbl;

    interface IOPCWrappedServer
    {
        CONST_VTBL struct IOPCWrappedServerVtbl *lpVtbl;
    };

    

#ifdef COBJMACROS


#define IOPCWrappedServer_QueryInterface(This,riid,ppvObject)	\
    (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)

#define IOPCWrappedServer_AddRef(This)	\
    (This)->lpVtbl -> AddRef(This)

#define IOPCWrappedServer_Release(This)	\
    (This)->lpVtbl -> Release(This)


#define IOPCWrappedServer_Load(This,tClsid)	\
    (This)->lpVtbl -> Load(This,tClsid)

#define IOPCWrappedServer_Unload(This)	\
    (This)->lpVtbl -> Unload(This)

#endif /* COBJMACROS */


#endif 	/* C style interface */



HRESULT STDMETHODCALLTYPE IOPCWrappedServer_Load_Proxy( 
    IOPCWrappedServer * This,
    /* [in] */ REFCLSID tClsid);


void __RPC_STUB IOPCWrappedServer_Load_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);


HRESULT STDMETHODCALLTYPE IOPCWrappedServer_Unload_Proxy( 
    IOPCWrappedServer * This);


void __RPC_STUB IOPCWrappedServer_Unload_Stub(
    IRpcStubBuffer *This,
    IRpcChannelBuffer *_pRpcChannelBuffer,
    PRPC_MESSAGE _pRpcMessage,
    DWORD *_pdwStubPhase);



#endif 	/* __IOPCWrappedServer_INTERFACE_DEFINED__ */



#ifndef __OpcDaServerLib_LIBRARY_DEFINED__
#define __OpcDaServerLib_LIBRARY_DEFINED__

/* library OpcDaServerLib */
/* [version][uuid] */ 


EXTERN_C const IID LIBID_OpcDaServerLib;

EXTERN_C const CLSID CLSID_OpcDaWrapper;

#ifdef __cplusplus

class DECLSPEC_UUID("1437DC7F-D66E-4aa3-BA79-2CD0A4A6F3D8")
OpcDaWrapper;
#endif
#endif /* __OpcDaServerLib_LIBRARY_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


